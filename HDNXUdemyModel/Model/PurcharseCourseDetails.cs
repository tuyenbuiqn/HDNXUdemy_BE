using HDNXUdemyModel.Base;
using HDNXUdemyModel.Model;

namespace HDNXUdemyData.Entities
{
    public class PurcharseCourseDetailsModel : BaseModel
    {
        public int IdCourse { get; set; }

        public int IdStudent { get; set; }

        public decimal? PriceOfCourse { get; set; }

        public decimal? PriceOfDiscount { get; set; }

        public int IdPurchaseOrder { get; set; }

        public CourseModel? Courses { get; set; }
    }
}