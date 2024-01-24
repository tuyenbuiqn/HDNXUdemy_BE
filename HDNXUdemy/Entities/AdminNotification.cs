namespace HDNXUdemyData.Entities
{
    public class AdminNotificationEntities : BaseEntities
    {
        public int IdComment { get; set; }

        public int IdTypeComment { get; set; }

        public int IdCourse { get; set; }

        public string? ShortComment { get; set; }
    }
}