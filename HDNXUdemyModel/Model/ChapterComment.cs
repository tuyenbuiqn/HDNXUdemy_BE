using HDNXUdemyModel.Base;

namespace HDNXUdemyModel.Model
{
    public class ChapterCommentModel : BaseModel
    {
        public int IdCourse { get; set; }
        public int IdStudent { get; set; }

        public int IdContentDetail { get; set; }

        public string? Comment { get; set; }
    }
}