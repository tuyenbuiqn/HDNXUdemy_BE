using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class StudentPromotionModel : BaseModel
    {
        public Guid IdCourse { get; set; }

        public Guid IdStudent { get; set; }

        public Guid IdPromotion { get; set; }

        public string? CodePromotion { get; set; }

        public int ValuePromotion { get; set; }
    }
}