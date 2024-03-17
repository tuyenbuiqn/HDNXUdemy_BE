using Asp.Versioning;
using HDNXUdemyModel.Base;
using HDNXUdemyModel.Constant;
using HDNXUdemyModel.Model;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HDNXUdemyAPI.Controllers
{
    /// <summary>
    /// PurchaseCourseController
    /// </summary>
    [ApiVersion(VersionApi.Version1)]
    [Route(RouterControllerName.PurchaseCourse)]
    public class PurchaseCourseController : BaseController
    {
        private readonly IPurcharseCourseServices _purcharseCourseServices;

        /// <summary>
        /// PurchaseCourseController
        /// </summary>
        /// <param name="purcharseCourseServices"></param>
        /// <exception cref="ProjectException"></exception>
        public PurchaseCourseController(IPurcharseCourseServices purcharseCourseServices)
        {
            _purcharseCourseServices = purcharseCourseServices ?? throw new ProjectException(nameof(_purcharseCourseServices));
        }

        /// <summary>
        /// GenPurchaseOrder
        /// </summary>
        /// <param name="idStudent"></param>
        /// <returns></returns>
        [HttpGet("gen-purchase-code/{idStudent}")]
        public RepositoryModel<string> GenPurchaseOrder(int idStudent)
        {
            RepositoryModel<string> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = string.Empty,
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = _purcharseCourseServices.GenPurchaseOrder(idStudent);
            return result;
        }

        /// <summary>
        /// CreateRequestPurchase
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("create-purchase")]
        public async Task<RepositoryModel<PurcharseCourseModel>> CreateRequestPurchase(PurcharseCourseModel model)
        {
            RepositoryModel<PurcharseCourseModel> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new PurcharseCourseModel(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _purcharseCourseServices.CreateRequestPurchase(model);
            return result;
        }

        /// <summary>
        /// UpdateStatusPurchase
        /// </summary>
        /// <param name="id"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("purchase-course/{id}")]
        public async Task<RepositoryModel<bool>> UpdateStatusPurchase(int id, PurcharseCourseModel model)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _purcharseCourseServices.UpdateStatusPurchase(id, model);
            return result;
        }

        /// <summary>
        /// IsCheckCoursePurchase
        /// </summary>
        /// <param name="idCourse"></param>
        /// <returns></returns>
        [HttpGet("check-purchase-course/{idCourse}")]
        public async Task<RepositoryModel<bool>> IsCheckCoursePurchase(int idCourse)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = false,
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _purcharseCourseServices.IsCheckCoursePurchase(idCourse);
            return result;
        }

        /// <summary>
        /// GetListPurcharseCourses
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        [HttpGet("get-list-purchase-course/{pageIndex}/{pageSize}")]
        public async Task<RepositoryModel<PagedResult<PurcharseCourseModel>>> GetListPurcharseCourses(int pageIndex, int pageSize)
        {
            RepositoryModel<PagedResult<PurcharseCourseModel>> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data =new PagedResult<PurcharseCourseModel>(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _purcharseCourseServices.GetListPurcharseCourses(pageIndex, pageSize);
            return result;
        }
    }
}