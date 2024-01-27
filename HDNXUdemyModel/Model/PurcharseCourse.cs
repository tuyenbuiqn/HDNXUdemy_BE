using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class PurcharseCourseModel : BaseModel
    {
        public int IdStudent { get; set; }
        public int IdCourse { get; set; }

        public string? ContentTranferBanking { get; set; }

        public decimal? PriceOfCourse { get; set; }

        public int PurcharseStatus { get; set; }

        public string? PurcharseCode { get; set; }

        public decimal? PriceOfDiscount { get; set; }

        public bool? IsDiscount { get; set; }
    }
}