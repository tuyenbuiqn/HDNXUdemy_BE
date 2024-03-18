using AutoMapper;
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
using Microsoft.AspNetCore.SignalR;
using NetTopologySuite.Index.HPRtree;
using NodaTime;

namespace HDNXUdemyServices.Services
{
    public class PurcharseCourseServices : IPurcharseCourseServices
    {
        private readonly IPurcharseCourseRepository _purcharseCourseRepository;
        private readonly IRPPurcharseCourseDetailsRepository _purcharseCourseDetailsRepository;
        private readonly IMapper _mapper;
        private readonly IHubContext<HubConfigProject> _hubConfigProject;
        private readonly ICourseRepository _courseRepository;
        private readonly INotificationRepository _notificationRepository;
        private readonly IInformationManualBankingRepository _informationManualBankingRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IPurcharseCourseRepository _pucharseCourseRepository;
        private readonly IUserRepository _userRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PurcharseCourseServices(IPurcharseCourseRepository purcharseCourseRepository, IMapper mapper, IHubContext<HubConfigProject> hubConfigProject,
            ICourseRepository courseRepository, INotificationRepository notificationRepository, IInformationManualBankingRepository informationManualBankingRepository,
            IRPPurcharseCourseDetailsRepository purcharseCourseDetailsRepository, IHttpContextAccessor httpContextAccessor, IPurcharseCourseRepository pucharseCourseRepository,
            IUserRepository userRepository, ICategoryRepository categoryRepository)
        {
            _purcharseCourseRepository = purcharseCourseRepository ?? throw new ProjectException(nameof(_purcharseCourseRepository));
            _mapper = mapper ?? throw new ProjectException(nameof(_mapper));
            _hubConfigProject = hubConfigProject ?? throw new ProjectException(nameof(_hubConfigProject));
            _courseRepository = courseRepository ?? throw new ProjectException(nameof(_courseRepository));
            _notificationRepository = notificationRepository ?? throw new ProjectException(nameof(_notificationRepository));
            _informationManualBankingRepository = informationManualBankingRepository ?? throw new ProjectException(nameof(_informationManualBankingRepository));
            _purcharseCourseDetailsRepository = purcharseCourseDetailsRepository ?? throw new ProjectException(nameof(_purcharseCourseDetailsRepository));
            _httpContextAccessor = httpContextAccessor ?? throw new ProjectException(nameof(_httpContextAccessor));
            _pucharseCourseRepository = pucharseCourseRepository ?? throw new ProjectException(nameof(_pucharseCourseRepository));
            _userRepository = userRepository ?? throw new ProjectException(nameof(_userRepository));
            _categoryRepository = categoryRepository ?? throw new ProjectException(nameof(_categoryRepository));
        }

        public string GenPurchaseOrder(int idStudent)
        {
            return Generator.GenerateRandomString(idStudent);
        }

        public async Task<PurcharseCourseModel> CreateRequestPurchase(PurcharseCourseModel model)
        {
            var getValueOfInfoPurechase = _mapper.Map<InformationManualBankingModel>(
                (await _informationManualBankingRepository.GetAsync(x => x.Status == (int)EStatus.Active)).FirstOrDefault());

            model.PurcharseStatus = (int)ETypeOfStatusOrder.Request;
            var dataInsert = _mapper.Map<PurcharseCourseEntities>(model);
            var addReturnModel = await _purcharseCourseRepository.AddReturnModelAsync(dataInsert);

            model.ListPurchaseCourseDetails?.ForEach(item =>
            {
                item.IdPurchaseOrder = (int)addReturnModel.Id;
                item.IdStudent = addReturnModel.IdStudent;
            });
            var dataInsertDetail = _mapper.Map<List<PurcharseCourseDetailsEntities>>(model.ListPurchaseCourseDetails);
            await _purcharseCourseDetailsRepository.AddManyAsync(dataInsertDetail);

            return model;
        }

        public async Task<bool> UpdateStatusPurchase(int id, PurcharseCourseModel model)
        {
            var getData = await _purcharseCourseRepository.GetByIdAsync(id) ?? new PurcharseCourseEntities();
            getData.Status = model.Status;
            getData.PurcharseStatus = model.PurcharseStatus;
            bool returnValue = await _purcharseCourseRepository.UpdateAsync(getData);
            if (returnValue)
            {
                var getDataOfCourse = await _courseRepository.GetObjectAsync(id);
                var dataInsertNotification = new NotificationEntities()
                {
                    IdCourse = (int)(getDataOfCourse?.Id ?? 0),
                    ShortComment = $"Khoá học {getDataOfCourse?.Title} đã thanh toán thành công",
                    IdStudent = model.IdStudent,
                    IsRead = false,
                    TypeNotification = (int)TypeNotification.UpdateOnCourse,
                };

                var insertNotification = await _notificationRepository.AddReturnModelAsync(dataInsertNotification);
                var contentNotification = new InfoNotification()
                {
                    IdNotification = insertNotification.Id.ToString(),
                    IsRead = insertNotification.IsRead,
                    NotificationContent = insertNotification.ShortComment,
                };
                await _hubConfigProject.Clients.Client(model.IdStudent.ToString())
                    .SendAsync(TypeNotification.UpdateOnCourse.GetEnumDescription(), contentNotification);
            }
            return returnValue;
        }

        public async Task<bool> IsCheckCoursePurchase(int idCourse)
        {
            int idCurrentUser = _httpContextAccessor.HttpContext == null ? 1 : int.Parse(_httpContextAccessor.HttpContext.User.Claims
                    .Where(x => x.Type == "user-id").FirstOrDefault()?.Value ?? "0");
            if (idCurrentUser == 0) return false;
            var isPurchaseCourseDetails = await _purcharseCourseDetailsRepository.GetAsync(x => x.IdCourse == idCourse && x.IdStudent == idCurrentUser);
            return isPurchaseCourseDetails.Any();
        }

        public async Task<PagedResult<PurcharseCourseModel>> GetListPurcharseCourses(int pageIndex, int pageSize)
        {
            DateTime firstDayOfCurrentMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime firstDayOfPreviousMonth = firstDayOfCurrentMonth.AddMonths(-1);
            DateTime currentDayOfCurrentMonth = DateTime.Now;
            DateTime currentDayOfPreviousMonth = currentDayOfCurrentMonth.AddMonths(-1);
            var getData = (await _pucharseCourseRepository.GetAsync(x => x.Status == (int)EStatus.Active))
                .OrderByDescending(x => x.CreateDate)
                .GetPagingPaged(pageIndex, pageSize, null);
            var returnValue = _mapper.Map<PagedResult<PurcharseCourseModel>>(getData);
            var getDataOfCurrentMonth = await _pucharseCourseRepository.GetAsync(x => x.CreateDate >= LocalDateTime.FromDateTime(firstDayOfCurrentMonth)
                            && x.CreateDate <= LocalDateTime.FromDateTime(currentDayOfCurrentMonth));
            var getDataOfPreviousMonth = await _pucharseCourseRepository.GetAsync(x => x.CreateDate >= LocalDateTime.FromDateTime(firstDayOfPreviousMonth)
                                        && x.CreateDate <= LocalDateTime.FromDateTime(currentDayOfPreviousMonth));
            foreach (var item in returnValue.Results)
            {
                item.User = _mapper.Map<UserModel>(await _userRepository.GetByIdAsync(item.IdStudent));
                item.NameStatus = ((ETypeOfStatusOrder)item.PurcharseStatus).GetEnumDescription();
            }
            returnValue.Results[0].ValueOfDataCount = GetDataValueForStatusOfPurchaseOrder(getDataOfCurrentMonth.ToList(), getDataOfPreviousMonth.ToList());
            return returnValue;
        }

        public async Task<PurcharseCourseModel> GetPurchaseCorseDetail(int idPurchase)
        {
            var getDataPurchaseOrder = await _pucharseCourseRepository.GetByIdAsync(idPurchase);
            var getDataPurchaseOrderDetail = await _purcharseCourseDetailsRepository.GetAsync(x => x.IdPurchaseOrder == idPurchase && x.Status == (int)EStatus.Active);
            var getDataStudent = await _userRepository.GetByIdAsync(getDataPurchaseOrder.IdStudent);
            var returnData = _mapper.Map<PurcharseCourseModel>(getDataPurchaseOrder);
            var getCategory = await _categoryRepository.GetAllAsync();
            returnData.ListPurchaseCourseDetails = _mapper.Map<List<PurcharseCourseDetailsModel>>(getDataPurchaseOrderDetail);
            returnData.User = _mapper.Map<UserModel>(getDataStudent);
            returnData.NameStatus = ((ETypeOfStatusOrder)returnData.PurcharseStatus).GetEnumDescription();

            foreach (var item in returnData.ListPurchaseCourseDetails)
            {
                item.Courses = _mapper.Map<CourseModel>(await _courseRepository.GetObjectAsync(x => x.Id == item.IdCourse && x.Status == (int)EStatus.Active));
                item.Courses.CategoryName = getCategory.Where(x => x.Id == item.Courses.IdCategory).FirstOrDefault()?.Name;
                item.Courses.AmountOfTheCourse = item.Courses.IsDiscount == true ? item.Courses.PriceOfDiscount : item.Courses.PriceOfCourse;
            }
            return returnData;
        }

        private List<ValuePurchaseOrderCount> GetDataValueForStatusOfPurchaseOrder(List<PurcharseCourseEntities> currentPurcharseCourseModels, List<PurcharseCourseEntities> sameWithCurrentPurcharseCourseModels)
        {
            var listValuePurchaseOrderStatus = new List<ValuePurchaseOrderCount>();
            var resultDataMapper = currentPurcharseCourseModels.GroupBy(x => x.PurcharseStatus);
            foreach (var item in resultDataMapper)
            {
                var valueOfSameWithPurchase = sameWithCurrentPurcharseCourseModels.Where(x => x.PurcharseStatus == item.Key);
                var dataReturn = new ValuePurchaseOrderCount()
                {
                    KeyValue = ((ETypeOfStatusOrder)item.Key).GetEnumDescription(),
                    PercentBasePreviewMonth = valueOfSameWithPurchase.Sum(x => x.TotalPrice) > 0 ? item.Sum(x => x.TotalPrice) ?? 0 / valueOfSameWithPurchase.Sum(x => x.TotalPrice) : 0,
                    ValueOfCurrent = item.Sum(x => x.TotalPrice),
                    UpOrDown = valueOfSameWithPurchase.Sum(x => x.TotalPrice) - item.Sum(x => x.TotalPrice) > 0 ? 0 : 1,
                };
                listValuePurchaseOrderStatus.Add(dataReturn);
            }

            return listValuePurchaseOrderStatus;
        }
    }
}