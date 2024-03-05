using HDNXUdemyModel.Base;

namespace HDNXUdemyData.Entities
{
    public class PurcharseCourseDetailsModel : BaseModel
    {
        public int IdCourse { get; set; }

        public decimal? PriceOfCourse { get; set; }

        public decimal? PriceOfDiscount { get; set; }

        public int IdPurchaseOrder { get; set; }
    }
}