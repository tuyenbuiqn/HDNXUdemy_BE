using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class TheadQuestionCourseModel : BaseModel
    {
        public Guid IdStudent { get; set; }

        public Guid IdCourse { get; set; }

        public string? Comment { get; set; }

        public int Like { get; set; }

        public int DisLike { get; set; }
    }
}