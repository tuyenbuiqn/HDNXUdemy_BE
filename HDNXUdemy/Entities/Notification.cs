namespace HDNXUdemyData.Entities
{
    public class NotificationEntities : BaseEntities
    {
        public int IdComment { get; set; }

        public int TypeNotification { get; set; }

        public int IdCourse { get; set; }

        public string? ShortComment { get; set; }
    }
}