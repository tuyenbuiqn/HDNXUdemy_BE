using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class AdminNotificationModel : BaseModel
    {
        public int IdComment { get; set; }

        public int IdTypeComment { get; set; }

        public int IdCourse { get; set; }

        public string? ShortComment { get; set; }
    }
}