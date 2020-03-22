using AspNetCoreWebApiSocialAuth.Models;
using System.Threading.Tasks;

namespace AspNetCoreWebApiSocialAuth.Core
{
    public interface ISocialAuth
    {
        /// <summary>
        /// This method checks if the user token is issued by this application
        /// </summary>
        /// <param name="appId">Facebook App ID</param>
        /// <param name="appSecret">Facebook App Secret</param>
        /// <param name="userToken">The access_token return by Facebook</param>
        /// <returns> validation result of the token from Facebook</returns>
        Task<FacebookValidationResult> ValidateFacebookUserToken(string appId, string appSecret, string userToken);

        /// <summary>
        /// This method retrieves the user profile from Facebook
        /// </summary>
        /// <param name="userToken"></param>
        /// <returns></returns>
        Task<FacebookAuthResult> GetUserFacebookProfile(string userToken);

        /// <summary>
        /// This method retrieves the user profile from Google
        /// </summary>
        /// <param name="clientId">App Google client_id </param>
        /// <param name="userToken">The access_token returned from Google</param>
        /// <returns></returns>
        Task<GoogleAuthResult> GetUserGoogleProfile(string clientId, string userToken);
    }
}
