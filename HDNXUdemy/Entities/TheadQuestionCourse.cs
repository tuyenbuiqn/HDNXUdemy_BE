namespace HDNXUdemyData.Entities
{
    public class TheadQuestionCourseEntities : BaseEntities
    {
        public int IdStudent { get; set; }

        public int IdCourse { get; set; }

        public string? Comment { get; set; }

        public int Like { get; set; }

        public int DisLike { get; set; }
    }
}