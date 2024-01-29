using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class NotificationModel : BaseModel
    {
        public int? IdComment { get; set; }

        public int? TypeNotification { get; set; }

        public int? IdCourse { get; set; }

        public int? IdStudent { get; set; }

        public string? ShortComment { get; set; }

        public bool? IsRead { get; set; }
    }
}