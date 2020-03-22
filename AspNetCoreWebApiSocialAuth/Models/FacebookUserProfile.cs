
namespace AspNetCoreWebApiSocialAuth.Models
{
    public class FacebookUserProfile
    {
        public string Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Middle_Name { get; set; }
        public ProfilePicture Picture { get; set; }
        public string Email { get; set; }
    }
    public class ProfilePicture
    {
        public PictureData Data { get; set; }
    }

    public class PictureData
    {
        public int Height { get; set; }
        public bool Is_Silhouette { get; set; }
        public string Url { get; set; }
        public int Width { get; set; }
    }

    public class FacebookAuthResult
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }

        public FacebookAuthResult(FacebookUserProfile profile)
        {
            Id = profile.Id;
            FirstName = profile.First_Name;
            LastName = profile.Last_Name;
            MiddleName = profile.Middle_Name;
            Picture = profile.Picture.Data.Url;
            Email = profile.Email;
        }
    }
}
