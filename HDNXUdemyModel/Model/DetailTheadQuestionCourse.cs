using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class DetailTheadQuestionCourseModel : BaseModel
    {
        public int IdTheadQuestionCourse { get; set; }

        public int IdStudent { get; set; }

        public string? Comment { get; set; }

        public int Like { get; set; }

        public int DisLike { get; set; }
    }
}