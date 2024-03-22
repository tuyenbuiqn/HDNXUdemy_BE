using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;

namespace HDNXUdemyServices.IServices
{
    public interface IStripeServices
    {
        Task<CheckoutSessionResponse> CreateCheckoutSession(PurcharseCourseModel model);
    }
}