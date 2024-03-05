using HDNXUdemyData.Entities;
using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class PurcharseCourseModel : BaseModel
    {
        public int IdStudent { get; set; }

        public string? ContentTranferBanking { get; set; }

        public decimal? TotalPrice { get; set; }

        public decimal? DiscountAmount { get; set; }

        public int PurcharseStatus { get; set; }

        public string? PurcharseCode { get; set; }

        public List<PurcharseCourseDetailsModel>? ListPurchaseCourseDetails { get; set; }

        public InformationManualBankingModel? InfoBanking { get; set; }
    }
}