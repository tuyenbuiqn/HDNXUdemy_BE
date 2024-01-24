using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class PurcharseCourseModel : BaseModel
    {
        public int IdStudent { get; set; }
        public int IdCourse { get; set; }

        public string? ContentTranferBanking { get; set; }

        public string? PriceOfCourse { get; set; }

        public int PurcharseStatus { get; set; }
    }
}