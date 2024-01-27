using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class NotificationModel : BaseModel
    {
        public int IdComment { get; set; }

        public int TypeNotification { get; set; }

        public int IdCourse { get; set; }

        public string? ShortComment { get; set; }
    }
}