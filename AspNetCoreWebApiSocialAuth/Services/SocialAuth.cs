using AspNetCoreWebApiSocialAuth.Consants;
using AspNetCoreWebApiSocialAuth.Core;
using AspNetCoreWebApiSocialAuth.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using static Google.Apis.Auth.GoogleJsonWebSignature;
using Newtonsoft.Json;

namespace AspNetCoreWebApiSocialAuth.Services
{
    public class SocialAuth : ISocialAuth
    {
        private readonly HttpClient _client = new HttpClient();

        public async Task<FacebookAuthResult> GetUserFacebookProfile(string userToken)
        {
            var url = SocialLink.FacebookProfile.Replace("{userToken}", userToken.Trim());

            var response = await _client.GetAsync(url);
            var content = await response.Content.ReadAsStringAsync();
            var profile = JsonConvert.DeserializeObject<FacebookUserProfile>(content);

            return new FacebookAuthResult(profile);
        }

        public async Task<GoogleAuthResult> GetUserGoogleProfile(string clientId, string userToken)
        {
            var payload = await ValidateAsync(userToken, new ValidationSettings
            {
                Audience = new[] { clientId }
            });

            return new GoogleAuthResult(payload);
        }

        public async Task<FacebookValidationResult> ValidateFacebookUserToken(string appId, string appSecret, string userToken)
        {
            var url = SocialLink.ValidateFacebookToken
                .Replace("{FacebookAppId}|{FacebookAppSecret}", appId)
                .Replace("{FacebookAppSecret}", appSecret)
                .Replace("{userToken}", userToken);

            var response = await _client.GetAsync(new Uri(url));
            var content = await response.Content.ReadAsStringAsync();
            var validationData = JsonConvert.DeserializeObject<FacebookValidationData>(content);

            return new FacebookValidationResult(validationData.Data);
        }
    }
}
