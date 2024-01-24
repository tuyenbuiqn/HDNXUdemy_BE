using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class StudentPromotionModel : BaseModel
    {
        public int IdCourse { get; set; }

        public int IdStudent { get; set; }

        public int IdPromotion { get; set; }

        public string? CodePromotion { get; set; }

        public int ValuePromotion { get; set; }
    }
}