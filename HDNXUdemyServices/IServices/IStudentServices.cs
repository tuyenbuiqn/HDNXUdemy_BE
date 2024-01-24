using HDNXUdemyModel.Model;

namespace HDNXUdemyServices.IServices
{
    public interface IStudentServices
    {
        Task<bool> CreateStudent(UserModel model);

        Task<bool> UpdateStatusStudent(int id, UserModel model);

        Task<bool> UpdateStudent(int id, UserModel model);

        Task<List<UserModel>> GetListStudents();

        Task<UserModel> GetStudent(int id);

        Task<bool> CreateStudentPromotions(StudentPromotionModel model);

        Task<bool> UpdateStatusStudentPromotions(int id, StudentPromotionModel model);

        Task<bool> UpdateInformationStudentPromotions(int id, StudentPromotionModel model);

        Task<List<StudentPromotionModel>> GetListStudentPromotions();

        Task<StudentPromotionModel> GetStudentPromotions(int id);

        Task<bool> CreateStudentProcess(StudentProcessModel model);

        Task<bool> UpdateStatusStudentProcess(int id, StudentProcessModel model);

        Task<bool> UpdateInformationStudentProcess(int id, StudentProcessModel model);

        Task<List<StudentProcessModel>> GetListStudentProcess();

        Task<StudentProcessModel> GetStudentProcess(int id);

        Task<bool> CreateStudentBookmarkCourse(BookmarkCourseModel model);

        Task<bool> UpdateStatusStudentBookmarkCourse(int id, BookmarkCourseModel model);

        Task<List<BookmarkCourseModel>> GetListStudentBookmarkCourse(int idUser);

        Task<bool> DeleteStudentBookmarkCourse(int id);

        Task<List<UserModel>> GetListUserManager();

        Task<List<UserModel>> GetListTeachers();
    }
}