using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;

namespace HDNXUdemyServices.IServices
{
    public interface IStripeServices
    {
        Task<CheckoutSessionResponse> CreateCheckoutSession(PurcharseCourseModel model);

        Task<bool> CreateCouponForPromotion(decimal percentOff, string? currency = "USD", string? typeDuration = "forever");

        Task<bool> DeleteCouponForPromotion(string stripeCouponId);

        Task<bool> CreateStripePromotionCode(string idCoupon, string promotionCode);

        Task<bool> InactivePromotionCode(string promotionCodeId);
    }
}