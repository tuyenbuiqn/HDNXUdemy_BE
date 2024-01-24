using HDNXUdemyModel.Model;

namespace HDNXUdemyServices.IServices
{
    public interface IPurcharseCourseServices
    {
        Task<bool> CreateRequestPurchase(PurcharseCourseModel model);

        Task<bool> UpdateStatusPurchase(int id, PurcharseCourseModel model);
    }
}