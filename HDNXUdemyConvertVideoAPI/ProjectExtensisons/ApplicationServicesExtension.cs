using Amazon.S3;
using HDNXUdemyData.GenericRepository;
using HDNXUdemyData.IRepository;
using HDNXUdemyData.Repository;
using HDNXUdemyServices.IServices;
using HDNXUdemyServices.Services;

namespace HDNXUdemyConvertVideoAPI.ProjectExtensisons
{
    /// <summary>
    /// ApplicationServicesExtensions
    /// </summary>
    public static class ApplicationServicesExtensions
    {
        /// <summary>
        /// AddApplicationServicesExtension
        /// </summary>
        /// <param name="services"></param>
        public static void AddApplicationServicesExtension(this IServiceCollection services)
        {
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient<IAdminNotificationRepository, AdminNotificationRepository>();
            services.AddTransient<IBannerRepository, BannerRepository>();
            services.AddTransient<IBookmarkCourseRepository, BookmarkCourseRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IChapterCommentRepository, ChapterCommentRepository>();
            services.AddTransient<IContentCourseRepository, ContentCourseRepository>();
            services.AddTransient<IContentCourseDetailRepository, ContentCourseDetailRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<ICourseCommentRepository, CourseCommentRepository>();
            services.AddTransient<IInformationManualBankingRepository, InformationManualBankingRepository>();
            services.AddTransient<IPurcharseCourseRepository, PurcharseCourseRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IStudentProcessRepository, StudentProcessRepository>();
            services.AddTransient<IStudentPromotionRepository, StudentPromotionRepository>();
            services.AddTransient<ISubCategoryRepository, SubCategoryRepository>();
            services.AddTransient<IFileManagerRepository, FileManagerRepository>();
            services.AddTransient<ISystemConfigRepository, SystemConfigRepository>();

            services.AddTransient(typeof(ILogServices<>), typeof(LogServices<>));
            services.AddHttpClient<IAuthenticationServices, AuthenticationServices>();
            services.AddTransient<IMasterDataServices, MasterDataServices>();
            services.AddTransient<ISendEmailSMSServices, SendEmailSMSServices>();
            services.AddTransient<IUploadDataToCloud, UploadDataToCloud>();
            services.AddTransient<IUploadFileVideoToServer, UploadFileVideoToServer>();
            services.AddTransient<ICourseServices, CourseServices>();
            services.AddAWSService<IAmazonS3>();
        }
    }
}