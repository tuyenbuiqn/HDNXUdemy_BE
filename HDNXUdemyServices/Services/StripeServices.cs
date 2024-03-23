using AutoMapper;
using HDNXUdemyData.Entities;
using HDNXUdemyData.IRepository;
using HDNXUdemyModel.Base;
using HDNXUdemyModel.Constant;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.CommonFunction;
using HDNXUdemyServices.IServices;
using Microsoft.Extensions.Caching.Distributed;
using Stripe;
using Stripe.Checkout;

namespace HDNXUdemyServices.Services
{
    public class StripeServices : IStripeServices
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;
        private readonly IRCouponRepository _couponRepository;
        private readonly IRPromotionCodeRepository _promotionCodeRepository;
        private readonly IDistributedCache _distributedCache;

        public StripeServices(ICourseRepository courseRepository, IMapper mapper, IRCouponRepository couponRepository, IRPromotionCodeRepository promotionCodeRepository,
            IDistributedCache distributedCache)
        {
            _courseRepository = courseRepository ?? throw new ProjectException(nameof(_courseRepository));
            _mapper = mapper ?? throw new ProjectException(nameof(_mapper));
            _couponRepository = couponRepository ?? throw new ProjectException(nameof(_couponRepository));
            _promotionCodeRepository = promotionCodeRepository ?? throw new ProjectException(nameof(_promotionCodeRepository));
            _distributedCache = distributedCache ?? throw new ProjectException(nameof(_distributedCache));
        }

        public async Task<CheckoutSessionResponse> CreateCheckoutSession(PurcharseCourseModel model)
        {
            var listSessionLineItemOption = new List<SessionLineItemOptions>();
            var returnValue = new CheckoutSessionResponse();
            foreach (var item in model.ListPurchaseCourseDetails)
            {
                var dataOfCoures = await _courseRepository.GetByIdAsync(item.IdCourse);
                var itemSessionItemOption = new SessionLineItemOptions()
                {
                    Quantity = 1,
                    PriceData = new SessionLineItemPriceDataOptions()
                    {
                        UnitAmountDecimal = dataOfCoures.PriceOfCourse,
                        Currency = "USD",
                        ProductData = new SessionLineItemPriceDataProductDataOptions()
                        {
                            Name = dataOfCoures.Title,
                            Images = new List<string> { dataOfCoures.PictureUrl },
                        }
                    },
                };
                listSessionLineItemOption.Add(itemSessionItemOption);
            }
            var options = new SessionCreateOptions
            {
                SuccessUrl = ProjectConfig.StripePaymentSuccessLink,
                CancelUrl = ProjectConfig.StripePaymentUnSuccessLink,
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                Mode = "payment",
                LineItems = listSessionLineItemOption,
                ClientReferenceId = model.PurcharseCode.ToString(),
            };

            try
            {
                var stripeServices = new SessionService();
                var session = await stripeServices.CreateAsync(options);
                returnValue.SessionId = session.Id;
                await DistributedCacheRedis.SetDataToDistributedCache(_distributedCache, model.PurcharseCode.ToString(), model);
            }
            catch (StripeException ex)
            {
                throw new ProjectException(ex.InnerException?.Message ?? string.Empty, ex);
            }
            return returnValue;
        }

        public async Task<bool> CreateStripePromotionCode(string idCoupon, string promotionCode)
        {
            try
            {
                var options = new PromotionCodeCreateOptions
                {
                    Coupon = idCoupon,
                    Code = promotionCode,
                    Active = true,
                };
                var service = new PromotionCodeService();
                var stripeCreatePromotionCode = await service.CreateAsync(options);
                var mapperStripeToModel = _mapper.Map<PromotionCodeModel>(stripeCreatePromotionCode);
                var dataInsert = _mapper.Map<PromotionCodeEntities>(mapperStripeToModel);
                return await _promotionCodeRepository.AddAsync(dataInsert);
            }
            catch (StripeException ex)
            {
                throw new ProjectException(ex.InnerException?.Message ?? string.Empty, ex);
            }
        }

        public async Task<bool> CreateCouponForPromotion(decimal percentOff, string? currency = "USD", string? typeDuration = "forever")
        {
            var options = new CouponCreateOptions
            {
                Duration = typeDuration,
                PercentOff = percentOff,
                Currency = currency,
            };
            try
            {
                var service = new CouponService();
                var stripeCreateCoupon = await service.CreateAsync(options);
                var mapperStripeToModel = _mapper.Map<CouponModel>(stripeCreateCoupon);
                var dataInsert = _mapper.Map<CouponEntities>(mapperStripeToModel);
                return await _couponRepository.AddAsync(dataInsert);
            }
            catch (StripeException ex)
            {
                throw new ProjectException(ex.InnerException?.Message ?? string.Empty, ex);
            }
        }

        public async Task<bool> DeleteCouponForPromotion(string stripeCouponId)
        {
            try
            {
                var service = new CouponService();
                var deleteCouponStripe = await service.DeleteAsync(stripeCouponId);
                var getCouponOnData = await _couponRepository.GetObjectAsync(x => x.StripeCouponId == stripeCouponId);
                getCouponOnData.Status = (int)EStatus.Inactive;
                return await _couponRepository.UpdateAsync(getCouponOnData);
            }
            catch (StripeException ex)
            {
                throw new ProjectException(ex.InnerException?.Message ?? string.Empty, ex);
            }
        }

        public async Task<bool> InactivePromotionCode(string promotionCodeId)
        {
            try
            {
                var option = new PromotionCodeUpdateOptions()
                {
                    Active = false,
                };
                var service = new PromotionCodeService();
                var dataReturn = await service.UpdateAsync(promotionCodeId, option);
                return dataReturn.Id != string.Empty;
            }
            catch (StripeException ex)
            {
                throw new ProjectException(ex.InnerException?.Message ?? string.Empty, ex);
            }
        }
    }
}