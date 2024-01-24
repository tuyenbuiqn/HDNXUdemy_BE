using AutoMapper;
using HDNXUdemyData.IRepository;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.ResponModel;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.IServices;

namespace HDNXUdemyServices.Services
{
    public class HomeServices : IHomeServices
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IRPPartnerRepository _partnerRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public HomeServices(ICourseRepository courseRepository, IRPPartnerRepository partnerRepository,
            ICategoryRepository categoryRepository, IMapper mapper)
        {
            _courseRepository = courseRepository ?? throw new ProjectException(nameof(_courseRepository));
            _partnerRepository = partnerRepository ?? throw new ProjectException(nameof(_partnerRepository));
            _categoryRepository = categoryRepository ?? throw new ProjectException(nameof(_categoryRepository));
            _mapper = mapper ?? throw new ProjectException(nameof(_categoryRepository));
        }

        public async Task<HomeModel> GetDataForHome()
        {
            var returnValue = new HomeModel()
            {
                Partners = new List<PartnerModel>(),
                ListContentData = new List<ListContentOfCourse>()
            };
            var getDataOfCategory = await _categoryRepository.GetAllAsync();
            var getDataOfPartner = _mapper.Map<List<PartnerModel>>(await _partnerRepository.GetAllAsync());
            returnValue.Partners.AddRange(getDataOfPartner);
            var getDataOfBestIsBuy = new ListContentOfCourse()
            {
                NameContent = "Khoá học mua nhiều nhất",
                ListDataOfContent = _mapper.Map<List<CourseModel>>((await _courseRepository.GetAllAsync()).OrderBy(x => x.TotalStudentRegister).Take(10)),
            };
            returnValue.ListContentData.Add(getDataOfBestIsBuy);
            var getDataOfBestIsDisCount = new ListContentOfCourse()
            {
                NameContent = "Khoá học khuyến mãi",
                ListDataOfContent = _mapper.Map<List<CourseModel>>((await _courseRepository.GetAsync(x => x.IsDiscount == true)).OrderBy(x => x.CreateDate).Take(10))
            };
            returnValue.ListContentData.Add(getDataOfBestIsDisCount);
            foreach (var item in getDataOfCategory)
            {
                var getDataItem = new ListContentOfCourse()
                {
                    NameContent = item.Name,
                    ListDataOfContent = _mapper.Map<List<CourseModel>>((await _courseRepository.GetAsync(x => x.IdCategory == item.Id)).Take(10)),
                };
                returnValue.ListContentData.Add(getDataItem);
            }

            return returnValue;
        }
    }
}