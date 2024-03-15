using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;

namespace HDNXUdemyServices.IServices
{
    public interface IPurcharseCourseServices
    {
        Task<PurcharseCourseModel> CreateRequestPurchase(PurcharseCourseModel model);

        Task<bool> UpdateStatusPurchase(int id, PurcharseCourseModel model);

        string GenPurchaseOrder(int idStudent);

        Task<bool> IsCheckCoursePurchase(int idCourse);
    }
}