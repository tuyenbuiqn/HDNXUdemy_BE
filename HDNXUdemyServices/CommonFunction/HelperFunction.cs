using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using HDNXUdemyModel.Base;
using HDNXUdemyModel.Constant;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.IdentityModel.Tokens;
using NetTopologySuite.Noding;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;

namespace HDNXUdemyServices.CommonFunction
{
    public static class HelperFunction
    {
        public static string ConvertUtf8ToString(this string utf8String)
        {
            if (!String.IsNullOrEmpty(utf8String))
            {
                Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
                string temp = utf8String.ToLower().Trim().Normalize(NormalizationForm.FormD);
                return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').Replace(" ", "");
            }
            else
            {
                return utf8String;
            }
        }

        public static string ConvertToYYYYMMDD(this DateTime dateTimeConvert)
        {
            if (!String.IsNullOrEmpty(dateTimeConvert.ToString()))
            {
                return dateTimeConvert.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture.DateTimeFormat);
            }
            else
            {
                return String.Empty;
            }
        }

        public static DateTime? ConvertStringToDateTime(this string stringDateTimeConvert)
        {
            if (stringDateTimeConvert != null)
            {
                return Convert.ToDateTime(stringDateTimeConvert);
            }
            else
            {
                return null;
            }
        }

        public static string GenerateToken(string secret, int expiresDate, long userId, string email, string userName, int roleId)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("user-id", userId.ToString()),
                    new Claim("email", email),
                    new Claim("user-name", email),
                    new Claim(ClaimTypes.Role, ((ERoles)roleId).GetEnumDescription()),
                }),
                Expires = DateTime.Now.AddDays(expiresDate),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return tokenString;
        }

        public static string GenerateRefreshToken(string email)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(email);
            return Convert.ToBase64String(bytes);
        }

        public static bool CheckExpireRefreshToken(DateTime dateTimeCreateRefreshToken)
        {
            return dateTimeCreateRefreshToken > DateTime.UtcNow;
        }

        public static double DistanceTo(this CoorDinates baseCoordinates, CoorDinates targetCoordinates)
        {
            return DistanceTo(baseCoordinates, targetCoordinates, UnitOfLength.Kilometers);
        }

        public static double DistanceTo(this CoorDinates baseCoordinates, CoorDinates targetCoordinates, UnitOfLength unitOfLength)
        {
            var baseRad = Math.PI * baseCoordinates.Latitude / 180;
            var targetRad = Math.PI * targetCoordinates.Latitude / 180;
            var theta = baseCoordinates.Longitude - targetCoordinates.Longitude;
            var thetaRad = Math.PI * theta / 180;

            double dist =
                Math.Sin(baseRad) * Math.Sin(targetRad) + Math.Cos(baseRad) *
                Math.Cos(targetRad) * Math.Cos(thetaRad);
            dist = Math.Acos(dist);

            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            return unitOfLength.ConvertFromMiles(dist);
        }

        public static (string controllerName, string actionName, string key) GetDetailForActionKeyController(this ControllerActionDescriptor controllerDetail)
        {
            string controllerName = controllerDetail.ControllerName;
            string actionName = controllerDetail.ActionName;
            string key = DateTime.UtcNow.ToString(ProjectConfig.DateTimeSqlFormat);
            return (controllerName, actionName, key);
        }

        public static int GetCurrentUserId(this IHttpContextAccessor httpContextAccessor)
        {
            int idCurrentUser = httpContextAccessor.HttpContext == null ? 1 : int.Parse(httpContextAccessor.HttpContext.User.Claims
                                .Where(x => x.Type == "Id").FirstOrDefault()?.Value ?? "0");
            return idCurrentUser;
        }

        public static async Task<RenameResult?> GetPublicIdOfPicture(IFormFile fileImages)
        {
            var accountCloud = new Account(ProjectConfig.CloudName, ProjectConfig.APIKey, ProjectConfig.APISecret);
            var cloudinary = new Cloudinary(accountCloud);
            var uploadResult = new ImageUploadResult();
            if (fileImages.Length > 0)
            {
                using var stream = fileImages.OpenReadStream();
                fileImages.GetType();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(fileImages.FileName, stream),
                    Transformation = new Transformation().Height(949).Width(1920).Crop("fill").Gravity("face")
                };

                uploadResult = await cloudinary.UploadAsync(uploadParams);
            }

            if (uploadResult.PublicId != null)
            {
                string newNameFile = $"{fileImages.FileName}_{DateTime.UtcNow.Ticks}";
                var renameParams = new RenameParams(uploadResult.PublicId, newNameFile);

                return await cloudinary.RenameAsync(renameParams);
            }

            return null;
        }

        public static async Task<RenameResult?> GetPublicIdOfPictureWithBanner(IFormFile fileImages)
        {
            var accountCloud = new Account(ProjectConfig.CloudName, ProjectConfig.APIKey, ProjectConfig.APISecret);
            var cloudinary = new Cloudinary(accountCloud);
            var uploadResult = new ImageUploadResult();
            if (fileImages.Length > 0)
            {
                using var stream = fileImages.OpenReadStream();
                fileImages.GetType();
                var uploadParams = new ImageUploadParams
                {
                    File = new FileDescription(fileImages.FileName, stream),
                    Transformation = new Transformation().Height(949).Width(1920).Crop("fill").Gravity("face")
                };

                uploadResult = await cloudinary.UploadAsync(uploadParams);
            }

            if (uploadResult.PublicId != null)
            {
                string newNameFile = $"{fileImages.FileName}_{DateTime.UtcNow.Ticks}";
                var renameParams = new RenameParams(uploadResult.PublicId, newNameFile);

                return await cloudinary.RenameAsync(renameParams);
            }

            return null;
        }

        public static async Task<bool> DeleteImagesFromCloud(string publicId)
        {
            var accountCloud = new Account(ProjectConfig.CloudName, ProjectConfig.APIKey, ProjectConfig.APISecret);
            var cloudinary = new Cloudinary(accountCloud);
            var deletetionParams = new DeletionParams(publicId)
            {
                PublicId = publicId,
            };

            var resultDelete = await cloudinary.DestroyAsync(deletetionParams);
            return resultDelete.StatusCode == HttpStatusCode.OK;
        }

        public static decimal CalculatorToTalStartOfCourse(int vote1Star, int vote2Star, int vote3Star, int vote4Star, int vote5Star)
        {
            decimal totalVoteOfCourse = vote1Star + vote2Star + vote3Star + vote4Star + vote5Star;
            decimal totalVoteWithStart = (vote1Star * 1) + (vote2Star * 2) + (vote3Star * 3) + (vote4Star * 4) + (vote5Star * 5);
            if(totalVoteOfCourse == 0)
            {
                return 0;
            }
            return totalVoteWithStart / totalVoteOfCourse;
        }
    }
}