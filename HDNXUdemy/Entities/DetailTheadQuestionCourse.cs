namespace HDNXUdemyData.Entities
{
    public class DetailTheadQuestionCourseEntities : BaseEntities
    {
        public Guid IdTheadQuestionCourse { get; set; }

        public Guid IdStudent { get; set; }

        public string? Comment { get; set; }

        public int Like { get; set; }

        public int DisLike { get; set; }
    }
}