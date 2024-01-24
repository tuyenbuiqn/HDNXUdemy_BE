namespace HDNXUdemyData.Entities
{
    public class ChapterCommentEntities : BaseEntities
    {
        public int IdCourse { get; set; }
        public int IdStudent { get; set; }

        public int IdContentDetail { get; set; }

        public string? Comment { get; set; }
    }
}