namespace HDNXUdemyData.Entities
{
    public class PurcharseCourseDetailsEntities : BaseEntities
    {
        public int IdCourse { get; set; }

        public decimal? PriceOfCourse { get; set; }

        public decimal? PriceOfDiscount { get; set; }

        public int IdPurchaseOrder { get; set; }

    }
}