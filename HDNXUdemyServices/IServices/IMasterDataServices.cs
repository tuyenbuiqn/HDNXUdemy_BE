using HDNXUdemyData.Model;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;

namespace HDNXUdemyServices.IServices
{
    public interface IMasterDataServices
    {
        Task<bool> CreateCategory(CategoryModel category);

        Task<bool> UpdateStatusCategory(Guid id, CategoryModel category);

        Task<bool> UpdateInformationCategory(Guid id, CategoryModel category);

        Task<List<CategoryModel>> GetListCategory();

        Task<bool> DeleteCategory(Guid id);

        Task<bool> CreateBanner(BannerModel model);

        Task<bool> UpdateStatusBanner(Guid id, BannerModel model);

        Task<bool> UpdateInformationBanner(Guid id, BannerModel model);

        Task<List<BannerModel>> GetListBanner();

        Task<bool> CreateInformationManualBanking(InformationManualBankingModel model);

        Task<bool> UpdateStatusInformationManualBanking(Guid id, InformationManualBankingModel model);

        Task<bool> UpdateInformationManualBanking(Guid id, InformationManualBankingModel model);

        Task<InformationManualBankingModel> GetInformationManualBanking();

        Task<bool> CreateSubCategory(SubCategoryModel model);

        Task<bool> UpdateStatusSubCategory(Guid id, SubCategoryModel model);

        Task<bool> UpdateInformationSubCategory(Guid id, SubCategoryModel model);

        Task<List<SubCategoryModel>> GetListSubCategory();

        Task<SubCategoryModel> GetSubCategory(Guid id);

        List<ListTypeFileUpload> GetListFileTypeUpload();

        Task<bool> CreateConfigSystem(SystemConfigModel model);

        Task<bool> UpdateStatusConfigSystem(Guid id, SystemConfigModel model);

        Task<bool> UpdateInformationConfigSystem(Guid id, SystemConfigModel model);

        Task<List<SystemConfigModel>> GetListConfigSystem();

        Task<SystemConfigModel> GetConfigSystem(Guid id);

        List<ListTypeFileUpload> GetListOfFileTypeUpload();
    }
}