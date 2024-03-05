namespace HDNXUdemyData.Entities
{
    public class PurcharseCourseEntities : BaseEntities
    {
        public int IdStudent { get; set; }

        public string? ContentTranferBanking { get; set; }

        public decimal? TotalPrice { get; set; }

        public decimal? DiscountAmount { get; set; }

        public int PurcharseStatus { get; set; }

        public string? PurcharseCode { get; set; }
    }
}