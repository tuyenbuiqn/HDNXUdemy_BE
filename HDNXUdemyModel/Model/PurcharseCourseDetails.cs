using HDNXUdemyModel.Base;
using HDNXUdemyModel.Model;

namespace HDNXUdemyData.Entities
{
    public class PurcharseCourseDetailsModel : BaseModel
    {
        public Guid IdCourse { get; set; }

        public Guid IdStudent { get; set; }

        public decimal? PriceOfCourse { get; set; }

        public decimal? PriceOfDiscount { get; set; }

        public Guid IdPurchaseOrder { get; set; }

        public CourseModel? Courses { get; set; }
    }
}