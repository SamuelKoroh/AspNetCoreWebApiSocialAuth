
namespace AspNetCoreWebApiSocialAuth.Consants
{
    public class SocialLink
    {
        public const string ValidateFacebookToken = "https://graph.facebook.com/debug_token?input_token={userToken}&access_token={FacebookAppId}|{FacebookAppSecret}";
       
        public const string FacebookProfile = "https://graph.facebook.com/me?fields=id,first_name,middle_name,last_name,picture,email&access_token={userToken}";
    }
}
