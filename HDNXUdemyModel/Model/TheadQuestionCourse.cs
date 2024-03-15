using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class TheadQuestionCourseModel : BaseModel
    {
        public int IdStudent { get; set; }

        public int IdCourse { get; set; }

        public string? Comment { get; set; }

        public int Like { get; set; }

        public int DisLike { get; set; }
    }
}