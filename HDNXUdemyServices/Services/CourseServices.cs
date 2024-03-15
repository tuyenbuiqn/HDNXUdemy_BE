using AutoMapper;
using DNXUdemyData.Entities;
using HDNXUdemyData.Entities;
using HDNXUdemyData.IRepository;
using HDNXUdemyModel.Base;
using HDNXUdemyModel.Constant;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.CommonFunction;
using HDNXUdemyServices.IServices;
using Microsoft.AspNetCore.Http;
using NetTopologySuite.Index.HPRtree;

namespace HDNXUdemyServices.Services
{
    public class CourseServices : ICourseServices
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IContentCourseRepository _contentCourseRepository;
        private readonly IContentCourseDetailRepository _contentCourseDetailRepository;
        private readonly ICourseCommentRepository _courseCommentRepository;
        private readonly IChapterCommentRepository _chapterCommentRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IPurcharseCourseRepository _pucharseCourseRepository;
        private readonly IRPPurcharseCourseDetailsRepository _purcharseCourseDetailsRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CourseServices(ICourseRepository courseRepository, IContentCourseRepository contentCourseRepository, IContentCourseDetailRepository contentCourseDetailRepository,
            ICourseCommentRepository courseCommentRepository, IChapterCommentRepository chapterCommentRepository, IMapper mapper, ICategoryRepository categoryRepository,
            IUserRepository userRepository, IPurcharseCourseRepository pucharseCourseRepository, IRPPurcharseCourseDetailsRepository purcharseCourseDetailsRepository,
            IHttpContextAccessor httpContextAccessor)
        {
            _courseRepository = courseRepository ?? throw new ProjectException(nameof(_courseRepository));
            _contentCourseRepository = contentCourseRepository ?? throw new ProjectException(nameof(_contentCourseRepository));
            _contentCourseDetailRepository = contentCourseDetailRepository ?? throw new ProjectException(nameof(_contentCourseDetailRepository));
            _courseCommentRepository = courseCommentRepository ?? throw new ProjectException(nameof(_courseCommentRepository));
            _chapterCommentRepository = chapterCommentRepository ?? throw new ProjectException(nameof(_chapterCommentRepository));
            _categoryRepository = categoryRepository ?? throw new ProjectException(nameof(_categoryRepository));
            _userRepository = userRepository ?? throw new ProjectException(nameof(_userRepository));
            _mapper = mapper ?? throw new ProjectException(nameof(_mapper));
            _pucharseCourseRepository = pucharseCourseRepository ?? throw new ProjectException(nameof(_pucharseCourseRepository));
            _purcharseCourseDetailsRepository = purcharseCourseDetailsRepository ?? throw new ProjectException(nameof(_purcharseCourseDetailsRepository));
            _httpContextAccessor = httpContextAccessor ?? throw new ProjectException(nameof(_httpContextAccessor));

        }

        public async Task<bool> CreateCourse(CourseModel model)
        {
            var dataInsert = _mapper.Map<CourseEntities>(model);
            return await _courseRepository.AddAsync(dataInsert);
        }

        public async Task<bool> UpdateStatusCourse(int id, CourseModel model)
        {
            var getData = await _courseRepository.GetByIdAsync(id) ?? new CourseEntities();
            getData.Status = model.Status;
            getData.ProcessCourse = model.ProcessCourse;
            return await _courseRepository.UpdateStatusAsync(getData);
        }

        public async Task<bool> UpdateInformationCourse(int id, CourseModel model)
        {
            var getData = await _courseRepository.GetByIdAsync(id) ?? new CourseEntities();
            var dataInsert = _mapper.Map<CourseEntities>(model);
            dataInsert.CreateDate = getData.CreateDate;
            return await _courseRepository.UpdateAsync(dataInsert);
        }

        public async Task<List<CourseModel>> GetListCourseForAdmin()
        {
            var getData = await _courseRepository.GetAllAsync();
            var getCategory = await _categoryRepository.GetAllAsync();
            var resultMapping = _mapper.Map<List<CourseModel>>(getData);
            foreach (var item in resultMapping)
            {
                item.TotalVoteOfCourse = HelperFunction.CalculatorToTalStartOfCourse(item.Vote1Star ?? 0, item.Vote2Star ?? 0, item.Vote3Star ?? 0, item.Vote4Star ?? 0, item.Vote5Star ?? 0);
                item.CategoryName = getCategory.Where(x => x.Id == item.IdCategory).FirstOrDefault()?.Name;
                item.UserName = "Admin";
                item.ProcessCourseName = ((ProcessVideo)item.ProcessCourse).GetEnumDescription();
            }
            return resultMapping;
        }

        public async Task<List<CourseModel>> GetListCourseOfStudent(int idStudent)
        {
            var getIdOfPurchaseOrder = await _pucharseCourseRepository.
                GetAsync(x => x.IdStudent == idStudent && x.PurcharseStatus == (int)ETypeOfStatusOrder.Payment && x.Status == (int)EStatus.Active);
            var getIdOfCourseOfStudent = await _purcharseCourseDetailsRepository.GetAsync(item => getIdOfPurchaseOrder.Select(x => x.Id).Contains(item.IdPurchaseOrder));
            var getData = await _courseRepository.GetAsync(item => getIdOfCourseOfStudent.Select(x => x.IdCourse).Contains((int)item.Id));
            var getCategory = await _categoryRepository.GetAllAsync();
            var resultMapping = _mapper.Map<List<CourseModel>>(getData);
            foreach (var item in resultMapping)
            {
                item.TotalVoteOfCourse = HelperFunction.CalculatorToTalStartOfCourse(item.Vote1Star ?? 0, item.Vote2Star ?? 0, item.Vote3Star ?? 0, item.Vote4Star ?? 0, item.Vote5Star ?? 0);
                item.CategoryName = getCategory.Where(x => x.Id == item.IdCategory).FirstOrDefault()?.Name;
                item.UserName = (await _userRepository.GetByIdAsync(item.CreateBy))?.Name;
            }
            return resultMapping;
        }

        public async Task<GetCourseWithDetailsContent> GetDetailCourse(int id, bool isAdmin)
        {
            var getData = await _courseRepository.GetByIdAsync(id);
            var resultMapping = _mapper.Map<GetCourseWithDetailsContent>(getData);
            int idCurrentUser = _httpContextAccessor.HttpContext == null ? 1 : int.Parse(_httpContextAccessor.HttpContext.User.Claims
                                .Where(x => x.Type == "user-id").FirstOrDefault()?.Value ?? "0");
            idCurrentUser = 4;
            bool isPurchase = false;
            if (isAdmin)
            {
                isAdmin = true;
            }
            else
            {
                var isPurchaseCourseDetails = await _purcharseCourseDetailsRepository.GetAsync(x => x.IdCourse == id && x.IdStudent == idCurrentUser);

                if (isPurchaseCourseDetails.Any())
                {
                    var isPurchaseCourse = await _pucharseCourseRepository.GetByIdAsync(isPurchaseCourseDetails.FirstOrDefault().IdPurchaseOrder);
                    isPurchase = isAdmin = isPurchaseCourseDetails.Any() && isPurchaseCourse?.PurcharseStatus == (int)ETypeOfStatusOrder.Payment;
                }


            }

            if (getData != null && resultMapping != null)
            {
                var resultCourse = _mapper.Map<List<CourseModel>>((await _courseRepository.GetAsync(x => x.IdCategory == getData.IdCategory)).Take(3));
                var resultAuthor = _mapper.Map<UserModel>(await _userRepository.GetObjectAsync(x => x.Id == getData.CreateBy));
                var getCategory = await _categoryRepository.GetAllAsync();
                resultMapping.TotalVoteOfCourse = HelperFunction.CalculatorToTalStartOfCourse(resultMapping.Vote1Star ?? 0, resultMapping.Vote2Star ?? 0, resultMapping.Vote3Star ?? 0, resultMapping.Vote4Star ?? 0, resultMapping.Vote5Star ?? 0);
                resultMapping.CategoryName = getCategory.Where(x => x.Id == resultMapping.IdCategory).FirstOrDefault()?.Name;
                resultMapping.UserName = (await _userRepository.GetByIdAsync(resultMapping.CreateBy))?.Name;
                resultMapping.ProcessCourseName = ((ProcessVideo)resultMapping?.ProcessCourse).GetEnumDescription();
                resultMapping.ListContentCourseDetails = await GetContentOfCourse((int)getData.Id, isAdmin);
                resultMapping.ListCourseRate = resultCourse;
                resultMapping.Author = resultAuthor;
                resultMapping.FileUploadUrlStream = $"{ProjectConfig.APIUrlGetVideoMp4}{resultMapping.FileUrl}";
                resultMapping.IsPurchase = isPurchase;
            }

            return resultMapping ?? new GetCourseWithDetailsContent();
        }

        public async Task<List<StudentProcessModel>> GetListStudentProcess()
        {
            var getData = await _courseRepository.GetAllAsync();
            return _mapper.Map<List<StudentProcessModel>>(getData);
        }

        public async Task<StudentProcessModel> GetStudentProcess(int id)
        {
            var getData = await _courseRepository.GetByIdAsync(id);
            return _mapper.Map<StudentProcessModel>(getData);
        }

        public async Task<bool> CreateCommentCourse(CourseCommentModel model)
        {
            var dataInsert = _mapper.Map<CourseCommentEntities>(model);
            return await _courseCommentRepository.AddAsync(dataInsert);
        }

        public async Task<bool> UpdateStatusCommentCourse(int id, CourseCommentModel model)
        {
            var getData = await _courseCommentRepository.GetByIdAsync(id) ?? new CourseCommentEntities();
            getData.Status = model.Status;
            return await _courseCommentRepository.UpdateStatusAsync(getData);
        }

        public async Task<bool> UpdateInformationCommentCourse(int id, CourseCommentModel model)
        {
            var getData = await _courseCommentRepository.GetByIdAsync(id) ?? new CourseCommentEntities();
            var dataInsert = _mapper.Map<CourseCommentEntities>(model);
            dataInsert.CreateDate = getData.CreateDate;
            return await _courseCommentRepository.UpdateAsync(dataInsert);
        }

        public async Task<List<CourseCommentModel>> GetListCommentCourse(int idCourse)
        {
            var getData = await _courseCommentRepository.GetAsync(x => x.IdCourse == idCourse);
            return _mapper.Map<List<CourseCommentModel>>(getData);
        }

        public async Task<CourseCommentModel> GetCommentCourse(int id)
        {
            var getData = await _courseCommentRepository.GetByIdAsync(id);
            return _mapper.Map<CourseCommentModel>(getData);
        }

        public async Task<bool> CreateContentCourse(ContentCourseModel model)
        {
            var dataInsert = _mapper.Map<ContentCourseEntities>(model);
            return await _contentCourseRepository.AddAsync(dataInsert);
        }

        public async Task<bool> UpdateStatusContentCourse(int id, ContentCourseModel model)
        {
            var getData = await _contentCourseRepository.GetByIdAsync(id) ?? new ContentCourseEntities();
            getData.Status = model.Status;
            return await _contentCourseRepository.UpdateStatusAsync(getData);
        }

        public async Task<bool> UpdateInformationContentCourse(int id, ContentCourseModel model)
        {
            var getData = await _contentCourseRepository.GetByIdAsync(id) ?? new ContentCourseEntities();
            var dataInsert = _mapper.Map<ContentCourseEntities>(model);
            dataInsert.CreateDate = getData.CreateDate;
            return await _contentCourseRepository.UpdateAsync(dataInsert);
        }

        public async Task<List<ListContentWithDetailCourse>> GetListContentCourse(int idCourse)
        {
            var getData = await _contentCourseRepository.GetAsync(x => x.IdCourse == idCourse);
            var mappingDataContentCourse = _mapper.Map<List<ListContentWithDetailCourse>>(getData.OrderBy(x => x.CreateDate));
            foreach (var item in mappingDataContentCourse)
            {
                var getDataCourseDetail = await _contentCourseDetailRepository.GetAsync(x => x.IdContent == item.Id);
                item.ListContentCourseDetails = _mapper.Map<List<ContentCourseDetailModel>>(getDataCourseDetail);
            }

            return mappingDataContentCourse;
        }

        public async Task<ContentCourseModel> GetContentCourse(int id)
        {
            var getData = await _contentCourseRepository.GetByIdAsync(id);
            return _mapper.Map<ContentCourseModel>(getData);
        }

        public async Task<bool> CreateContentCourseDetails(ContentCourseDetailModel model)
        {
            var dataInsert = _mapper.Map<ContentCourseDetailEntities>(model);
            return await _contentCourseDetailRepository.AddAsync(dataInsert);
        }

        public async Task<bool> UpdateStatusContentCourseDetails(int id, ContentCourseDetailModel model)
        {
            var getData = await _contentCourseDetailRepository.GetByIdAsync(id) ?? new ContentCourseDetailEntities();
            getData.Status = model.Status;
            return await _contentCourseDetailRepository.UpdateStatusAsync(getData);
        }

        public async Task<bool> UpdateInformationContentCourseDetails(int id, ContentCourseDetailModel model)
        {
            var getData = await _contentCourseDetailRepository.GetByIdAsync(id) ?? new ContentCourseDetailEntities();
            var dataInsert = _mapper.Map<ContentCourseDetailEntities>(model);
            dataInsert.CreateDate = getData.CreateDate;
            return await _contentCourseDetailRepository.UpdateAsync(dataInsert);
        }

        public async Task<List<ContentCourseDetailModel>> GetListContentCourseDetails(int idContent)
        {
            var getData = await _contentCourseDetailRepository.GetAsync(x => x.IdContent == idContent);
            return _mapper.Map<List<ContentCourseDetailModel>>(getData);
        }

        public async Task<ContentCourseDetailModel> GetContentCourseDetails(int id, HttpRequest request)
        {
            var getData = await _contentCourseDetailRepository.GetByIdAsync(id);
            var resultMapping = _mapper.Map<ContentCourseDetailModel>(getData);
            resultMapping.FileUploadUrlStream = $"{ProjectConfig.APIUrlGetVideoStream}{resultMapping.FileNameVideo}";
            return resultMapping;
        }

        public async Task<List<ContentAndContentDetail>> GetContentOfCourse(int idCourse, bool isAdmin)
        {
            var resultData = new List<ContentAndContentDetail>();
            var getDataCourseContent = await _contentCourseRepository.GetAsync(x => x.IdCourse == idCourse);
            resultData = _mapper.Map<List<ContentAndContentDetail>>(getDataCourseContent.OrderBy(x => x.CreateDate));

            foreach (var item in resultData)
            {
                item.ContentAndContentDetails = new List<ContentCourseDetailModel>();
                if (isAdmin)
                {
                    item.ContentAndContentDetails = _mapper.Map<List<ContentCourseDetailModel>>(await _contentCourseDetailRepository.GetAsync(x => x.IdContent == item.Id));
                }
                else
                {
                    item.ContentAndContentDetails = _mapper.Map<List<ContentCourseDetailModel>>(await _contentCourseDetailRepository.GetAsync(x => x.IdContent == item.Id));
                    item.ContentAndContentDetails.ForEach(item =>
                    {
                        if (!item.IsLearningFree)
                        {
                            item.FileUploadUrlStream = null;
                        }
                    });
                }
            }

            return resultData;
        }

        public async Task<bool> CreateCommentChapter(ChapterCommentModel model)
        {
            var dataInsert = _mapper.Map<ChapterCommentEntities>(model);
            return await _chapterCommentRepository.AddAsync(dataInsert);
        }

        public async Task<bool> UpdateStatusCommentChapter(int id, ChapterCommentModel model)
        {
            var getData = await _chapterCommentRepository.GetByIdAsync(id) ?? new ChapterCommentEntities();
            getData.Status = model.Status;
            return await _chapterCommentRepository.UpdateStatusAsync(getData);
        }

        public async Task<bool> UpdateInformationCommentChapter(int id, ChapterCommentModel model)
        {
            var getData = await _chapterCommentRepository.GetByIdAsync(id) ?? new ChapterCommentEntities();
            var dataInsert = _mapper.Map<ChapterCommentEntities>(model);
            dataInsert.CreateDate = getData.CreateDate;
            return await _chapterCommentRepository.UpdateAsync(dataInsert);
        }

        public async Task<List<ChapterCommentModel>> GetListCommentChapter(int idCourse)
        {
            var getData = await _chapterCommentRepository.GetAsync(x => x.IdCourse == idCourse);
            return _mapper.Map<List<ChapterCommentModel>>(getData);
        }

        public async Task<ChapterCommentModel> GetCommentChapter(int id)
        {
            var getData = await _chapterCommentRepository.GetByIdAsync(id);
            return _mapper.Map<ChapterCommentModel>(getData);
        }

        public async Task<List<CourseModel>> GetListCourseAsCategory(int idCategory)
        {
            var getData = await _courseRepository.GetAsync(x => x.IdCategory == idCategory);
            return _mapper.Map<List<CourseModel>>(getData);
        }
    }
}