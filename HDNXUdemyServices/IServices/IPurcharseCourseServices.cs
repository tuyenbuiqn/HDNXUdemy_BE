using HDNXUdemyModel.Base;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;

namespace HDNXUdemyServices.IServices
{
    public interface IPurcharseCourseServices
    {
        Task<PurcharseCourseModel> CreateRequestPurchase(PurcharseCourseModel model);

        Task<bool> UpdateStatusPurchase(long id, PurcharseCourseModel model);

        string GenPurchaseOrder(long idStudent);

        Task<bool> IsCheckCoursePurchase(long idCourse);

        Task<PagedResult<PurcharseCourseModel>> GetListPurcharseCourses(int pageIndex, int pageSize);

        Task<PurcharseCourseModel> GetPurchaseCorseDetail(long idPurchase);
    }
}