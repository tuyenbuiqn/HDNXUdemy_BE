using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class CourseCommentModel : BaseModel
    {
        public int IdCourse { get; set; }
        public int IdStudent { get; set; }

        public string? Comment { get; set; }

        public int NumberStartVote { get; set; }
    }
}