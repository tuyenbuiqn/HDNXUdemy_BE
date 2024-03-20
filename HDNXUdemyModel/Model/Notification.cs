using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class NotificationModel : BaseModel
    {
        public Guid? IdComment { get; set; }

        public int? TypeNotification { get; set; }

        public Guid? IdCourse { get; set; }

        public Guid? IdStudent { get; set; }

        public string? ShortComment { get; set; }

        public bool? IsRead { get; set; }
    }
}