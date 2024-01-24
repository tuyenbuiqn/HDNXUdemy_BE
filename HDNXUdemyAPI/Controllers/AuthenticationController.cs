using Asp.Versioning;
using HDNXUdemyModel.Base;
using HDNXUdemyModel.Constant;
using HDNXUdemyModel.ResponModel;
using HDNXUdemyModel.SystemExceptions;
using HDNXUdemyServices.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HDNXUdemyAPI.Controllers
{
    /// <summary>
    /// AuthenticationController
    /// </summary>
    [ApiVersion(VersionApi.Version1)]
    [Route(RouterControllerName.Authentication)]
    public class AuthenticationController : BaseController
    {
        private readonly IAuthenticationServices _authenticationServices;

        /// <summary>
        /// AuthenticationController
        /// </summary>
        public AuthenticationController(IAuthenticationServices authenticationServices)
        {
            _authenticationServices = authenticationServices ?? throw new ProjectException(nameof(_authenticationServices));
        }

        /// <summary>
        /// LoginWithGoogle
        /// </summary>
        /// <param name="credential"></param>
        /// <returns></returns>
        [HttpPost("login-google")]
        public async Task<RepositoryModel<ResponeLogin>> LoginWithGoogle(string credential)
        {
            RepositoryModel<ResponeLogin> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new ResponeLogin(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _authenticationServices.LoginWithGoogle(credential, HttpContext);
            return result;
        }

        /// <summary>
        /// LoginWithFaceBook
        /// </summary>
        /// <param name="credential"></param>
        /// <returns></returns>
        [HttpPost("login-facebook")]
        public async Task<RepositoryModel<ResponeLogin>> LoginWithFaceBook(string credential)
        {
            RepositoryModel<ResponeLogin> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new ResponeLogin(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _authenticationServices.LoginWithFacebook(credential, HttpContext);
            return result;
        }

        /// <summary>
        /// RegisterUser
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost("register")]
        public async Task<RepositoryModel<bool>> RegisterUser(string email, string password)
        {
            RepositoryModel<bool> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new bool(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _authenticationServices.RegisterNormalUser(email, password);
            return result;
        }

        /// <summary>
        /// LoginNormalAccount
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<RepositoryModel<ResponeLogin>> LoginNormalAccount(string email, string password)
        {
            RepositoryModel<ResponeLogin> result = new()
            {
                PartnerCode = Messenger.SuccessFull,
                RetCode = ERetCode.Successfull,
                Data = new ResponeLogin(),
                SystemMessage = string.Empty,
                StatusCode = (int)HttpStatusCode.Created
            };

            result.Data = await _authenticationServices.LoginNormalAccount(email, password, HttpContext);
            return result;
        }
    }
}