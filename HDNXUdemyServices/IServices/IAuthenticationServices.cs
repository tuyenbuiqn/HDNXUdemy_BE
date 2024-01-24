using HDNXUdemyModel.ResponModel;
using Microsoft.AspNetCore.Http;

namespace HDNXUdemyServices.IServices
{
    public interface IAuthenticationServices
    {
        Task<ResponeLogin> LoginWithGoogle(string credential, HttpContext httpContext);

        Task<ResponeLogin> LoginWithFacebook(string credential, HttpContext httpContext);

        Task<bool> RegisterNormalUser(string email, string password);

        Task<ResponeLogin> LoginNormalAccount(string email, string password, HttpContext httpContext);

        Task<ResponeLogin> GeneralToken(string email, HttpContext httpContext);
    }
}