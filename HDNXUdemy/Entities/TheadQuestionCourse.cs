namespace HDNXUdemyData.Entities
{
    public class TheadQuestionCourseEntities : BaseEntities
    {
        public Guid IdStudent { get; set; }

        public Guid IdCourse { get; set; }

        public string? Comment { get; set; }

        public int Like { get; set; }

        public int DisLike { get; set; }
    }
}