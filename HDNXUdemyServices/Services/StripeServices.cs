using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.IServices;
using Stripe;
using Stripe.Checkout;

namespace HDNXUdemyServices.Services
{
    public class StripeServices : IStripeServices
    {
        public StripeServices()
        { }

        public async Task<CheckoutSessionResponse> CreateCheckoutSession(PurcharseCourseModel model)
        {
            var returnValue = new CheckoutSessionResponse();
            var options = new SessionCreateOptions
            {
                SuccessUrl = "https://localhost:4200",
                CancelUrl = "https://localhost:4200",
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                Mode = "payment",
                AllowPromotionCodes = true,
                Discounts = new List<SessionDiscountOptions>
                {
                    new SessionDiscountOptions
                    {
                        PromotionCode = string.Empty,
                        Coupon = string.Empty,
                    }
                },
                LineItems = new List<SessionLineItemOptions> { new SessionLineItemOptions
                {
                    PriceData = new SessionLineItemPriceDataOptions
                    {
                        UnitAmountDecimal = model.TotalPrice,
                        Currency = "VND",
                        ProductData = new SessionLineItemPriceDataProductDataOptions
                        {
                            Name = model.PurcharseCode.ToString(),
                            Description = model.ContentTranferBanking,
                        },
                    },

                    Quantity = 1,
                } }
            };

            try
            {
                var stripeServices = new SessionService();
                var session = await stripeServices.CreateAsync(options);
                returnValue.SessionId = session.Id;
            }
            catch (StripeException ex)
            {
                throw new ProjectException(ex.InnerException?.Message ?? string.Empty, ex);
            }
            return returnValue;
        }
    }
}