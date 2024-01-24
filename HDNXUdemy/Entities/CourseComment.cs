namespace HDNXUdemyData.Entities
{
    public class CourseCommentEntities : BaseEntities
    {
        public int IdCourse { get; set; }
        public int IdStudent { get; set; }

        public string? Comment { get; set; }
        public int NumberStartVote { get; set; }
    }
}