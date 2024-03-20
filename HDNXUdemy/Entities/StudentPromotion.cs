namespace HDNXUdemyData.Entities
{
    public class StudentPromotionEntities : BaseEntities
    {
        public Guid IdCourse { get; set; }

        public Guid IdStudent { get; set; }

        public Guid IdPromotion { get; set; }

        public string? CodePromotion { get; set; }

        public int ValuePromotion { get; set; }
    }
}