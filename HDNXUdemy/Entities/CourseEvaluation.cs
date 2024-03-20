namespace HDNXUdemyData.Entities
{
    public class CourseEvaluationEntities : BaseEntities
    {
        public Guid IdStudent { get; set; }

        public Guid IdCourse { get; set; }

        public int VoteStartNumber { get; set; }

        public string? CommentEvaluation { get; set; }

        public int Like { get; set; }

        public int DisLike { get; set; }
    }
}