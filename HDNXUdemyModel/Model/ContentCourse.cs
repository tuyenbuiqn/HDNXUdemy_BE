using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class ContentCourseModel : BaseModel
    {
        public string? Name { get; set; }

        public Guid IdCourse { get; set; }
    }
}