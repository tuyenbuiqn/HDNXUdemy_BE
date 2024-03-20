namespace HDNXUdemyData.Entities
{
    public class PurcharseCourseDetailsEntities : BaseEntities
    {
        public Guid IdCourse { get; set; }

        public Guid IdStudent { get; set; }

        public decimal? PriceOfCourse { get; set; }

        public decimal? PriceOfDiscount { get; set; }

        public Guid IdPurchaseOrder { get; set; }

    }
}