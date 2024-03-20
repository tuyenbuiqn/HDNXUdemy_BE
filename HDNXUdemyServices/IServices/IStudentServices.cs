using HDNXUdemyModel.Model;

namespace HDNXUdemyServices.IServices
{
    public interface IStudentServices
    {
        Task<bool> CreateStudent(UserModel model);

        Task<bool> UpdateStatusStudent(Guid id, UserModel model);

        Task<bool> UpdateStudent(Guid id, UserModel model);

        Task<List<UserModel>> GetListStudents();

        Task<UserModel> GetStudent(Guid id);

        Task<bool> CreateStudentPromotions(StudentPromotionModel model);

        Task<bool> UpdateStatusStudentPromotions(Guid id, StudentPromotionModel model);

        Task<bool> UpdateInformationStudentPromotions(Guid id, StudentPromotionModel model);

        Task<List<StudentPromotionModel>> GetListStudentPromotions();

        Task<StudentPromotionModel> GetStudentPromotions(Guid id);

        Task<bool> CreateStudentProcess(StudentProcessModel model);

        Task<bool> UpdateStatusStudentProcess(Guid id, StudentProcessModel model);

        Task<bool> UpdateInformationStudentProcess(Guid id, StudentProcessModel model);

        Task<List<StudentProcessModel>> GetListStudentProcess();

        Task<StudentProcessModel> GetStudentProcess(Guid id);

        Task<bool> CreateStudentBookmarkCourse(BookmarkCourseModel model);

        Task<bool> UpdateStatusStudentBookmarkCourse(Guid id, BookmarkCourseModel model);

        Task<List<CourseModel>> GetListStudentBookmarkCourse(Guid idUser);

        Task<bool> DeleteStudentBookmarkCourse(Guid id);

        Task<List<UserModel>> GetListUserManager();

        Task<List<UserModel>> GetListTeachers();

        Task<List<string?>> GetListUserNameRegisterForCourse(Guid idCourse);
    }
}