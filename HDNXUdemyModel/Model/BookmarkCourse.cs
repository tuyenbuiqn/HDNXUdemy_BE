using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class BookmarkCourseModel : BaseModel
    {
        public Guid IdStudent { get; set; }
        public Guid IdCourse { get; set; }
    }
}