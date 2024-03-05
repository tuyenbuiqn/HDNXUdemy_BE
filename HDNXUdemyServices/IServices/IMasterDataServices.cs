using HDNXUdemyData.Model;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;

namespace HDNXUdemyServices.IServices
{
    public interface IMasterDataServices
    {
        Task<bool> CreateCategory(CategoryModel category);

        Task<bool> UpdateStatusCategory(int id, CategoryModel category);

        Task<bool> UpdateInformationCategory(int id, CategoryModel category);

        Task<List<CategoryModel>> GetListCategory();

        Task<bool> DeleteCategory(int id);

        Task<bool> CreateBanner(BannerModel model);

        Task<bool> UpdateStatusBanner(int id, BannerModel model);

        Task<bool> UpdateInformationBanner(int id, BannerModel model);

        Task<List<BannerModel>> GetListBanner();

        Task<bool> CreateInformationManualBanking(InformationManualBankingModel model);

        Task<bool> UpdateStatusInformationManualBanking(int id, InformationManualBankingModel model);

        Task<bool> UpdateInformationManualBanking(int id, InformationManualBankingModel model);

        Task<InformationManualBankingModel> GetInformationManualBanking();

        Task<bool> CreateSubCategory(SubCategoryModel model);

        Task<bool> UpdateStatusSubCategory(int id, SubCategoryModel model);

        Task<bool> UpdateInformationSubCategory(int id, SubCategoryModel model);

        Task<List<SubCategoryModel>> GetListSubCategory();

        Task<SubCategoryModel> GetSubCategory(int id);

        List<ListTypeFileUpload> GetListFileTypeUpload();

        Task<bool> CreateConfigSystem(SystemConfigModel model);

        Task<bool> UpdateStatusConfigSystem(int id, SystemConfigModel model);

        Task<bool> UpdateInformationConfigSystem(int id, SystemConfigModel model);

        Task<List<SystemConfigModel>> GetListConfigSystem();

        Task<SystemConfigModel> GetConfigSystem(int id);

        List<ListTypeFileUpload> GetListOfFileTypeUpload();
    }
}