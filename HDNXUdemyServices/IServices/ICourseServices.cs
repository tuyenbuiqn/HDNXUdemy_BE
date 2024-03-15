using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using Microsoft.AspNetCore.Http;

namespace HDNXUdemyServices.IServices
{
    public interface ICourseServices
    {
        Task<bool> CreateCourse(CourseModel model);

        Task<bool> UpdateStatusCourse(int id, CourseModel model);

        Task<bool> UpdateInformationCourse(int id, CourseModel model);

        Task<List<StudentProcessModel>> GetListStudentProcess();

        Task<StudentProcessModel> GetStudentProcess(int id);

        Task<bool> AddCommentOfStudentForCourse(CourseEvaluationModel model);

        Task<List<CourseEvaluationModel>> GetListCoursEvaluation(int idCourse);

        Task<bool> UpdateStatusCommentCourse(int id, CourseEvaluationModel model);

        Task<bool> UpdateInformationCommentCourse(int id, CourseEvaluationModel model);

        Task<CourseEvaluationModel> GetCommentCourse(int id);

        Task<bool> CreateContentCourse(ContentCourseModel model);

        Task<bool> UpdateStatusContentCourse(int id, ContentCourseModel model);

        Task<bool> UpdateInformationContentCourse(int id, ContentCourseModel model);

        Task<List<ListContentWithDetailCourse>> GetListContentCourse(int idCourse);

        Task<ContentCourseModel> GetContentCourse(int id);

        Task<bool> CreateContentCourseDetails(ContentCourseDetailModel model);

        Task<bool> UpdateStatusContentCourseDetails(int id, ContentCourseDetailModel model);

        Task<bool> UpdateInformationContentCourseDetails(int id, ContentCourseDetailModel model);

        Task<List<ContentCourseDetailModel>> GetListContentCourseDetails(int idContent);

        Task<ContentCourseDetailModel> GetContentCourseDetails(int id, HttpRequest request);

        Task<bool> CreateTheadQuestionCourse(TheadQuestionCourseModel model);

        Task<bool> UpdateStatusTheadQuestionCourse(int id, TheadQuestionCourseModel model);

        Task<bool> UpdateInformationTheadQuestionCourse(int id, TheadQuestionCourseModel model);

        Task<List<TheadQuestionCourseModel>> GetListTheadQuestionCourse(int idCourse);

        Task<TheadQuestionCourseModel> GetTheadQuestionCourse(int id);

        Task<List<CourseModel>> GetListCourseForAdmin();

        Task<GetCourseWithDetailsContent> GetDetailCourse(int id, bool isAdmin);

        Task<List<CourseModel>> GetListCourseAsCategory(int idCategory);

        Task<List<CourseModel>> GetListCourseOfStudent(int idStudent);

        Task<bool> LikeForCommentCourse(int id);

        Task<bool> DisLikeForCommentCourse(int id);

        Task<bool> CreateDetailsTheadQuestionCourse(DetailTheadQuestionCourseModel model);

        Task<bool> UpdateStatusDetailsTheadQuestionCourse(int id, DetailTheadQuestionCourseModel model);

        Task<bool> UpdateInformationDetailsTheadQuestionCourse(int id, DetailTheadQuestionCourseModel model);

        Task<List<DetailTheadQuestionCourseModel>> GetListDetailsTheadQuestionCourse(int idThear);
    }
}