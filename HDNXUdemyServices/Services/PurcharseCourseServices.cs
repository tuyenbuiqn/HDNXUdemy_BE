using AutoMapper;
using HDNXUdemyData.Entities;
using HDNXUdemyData.IRepository;
using HDNXUdemyModel.Constant;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.IServices;

namespace HDNXUdemyServices.Services
{
    public class PurcharseCourseServices : IPurcharseCourseServices
    {
        private readonly IPurcharseCourseRepository _purcharseCourseRepository;
        private readonly IMapper _mapper;

        public PurcharseCourseServices(IPurcharseCourseRepository purcharseCourseRepository, IMapper mapper)
        {
            _purcharseCourseRepository = purcharseCourseRepository ?? throw new ProjectException(nameof(_purcharseCourseRepository));
            _mapper = mapper ?? throw new ProjectException(nameof(_mapper));
        }

        public async Task<bool> CreateRequestPurchase(PurcharseCourseModel model)
        {
            model.PurcharseStatus = (int)ETypeOfStatusOrder.Request;
            var dataInsert = _mapper.Map<PurcharseCourseEntities>(model);
            return await _purcharseCourseRepository.AddAsync(dataInsert);
        }

        public async Task<bool> UpdateStatusPurchase(int id, PurcharseCourseModel model)
        {
            var getData = await _purcharseCourseRepository.GetByIdAsync(id) ?? new PurcharseCourseEntities();
            getData.Status = model.Status;
            getData.PurcharseStatus = model.PurcharseStatus;
            return await _purcharseCourseRepository.UpdateAsync(getData);
        }
    }
}