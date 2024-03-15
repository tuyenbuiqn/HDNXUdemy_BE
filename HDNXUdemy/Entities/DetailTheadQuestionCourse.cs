namespace HDNXUdemyData.Entities
{
    public class DetailTheadQuestionCourseEntities : BaseEntities
    {
        public int IdTheadQuestionCourse { get; set; }

        public int IdStudent { get; set; }

        public string? Comment { get; set; }

        public int Like { get; set; }

        public int DisLike { get; set; }
    }
}