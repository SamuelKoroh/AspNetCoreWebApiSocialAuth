using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetCoreWebApiSocialAuth.Models
{
    public class FacebookValidationDetails
    {
        public string app_id { get; set; }
        public string type { get; set; }
        public string application { get; set; }
        public int data_access_expires_at { get; set; }
        public int expires_at { get; set; }
        public bool is_valid { get; set; }
        public List<string> scopes { get; set; }
        public string user_id { get; set; }
    }
    public class FacebookValidationData
    {
        public FacebookValidationDetails Data { get; set; }
    }
    public class FacebookValidationResult
    {
        public string AppId { get; set; }
        public string Type { get; set; }
        public string Application { get; set; }
        public int DataAccessExpiresAt { get; set; }
        public int ExpiresAt { get; set; }
        public bool IsValid { get; set; }
        public List<string> Scopes { get; set; }
        public string UserId { get; set; }

        public FacebookValidationResult(FacebookValidationDetails data)
        {
            AppId = data.app_id;
            Type = data.type;
            Application = data.application;
            DataAccessExpiresAt = data.data_access_expires_at;
            ExpiresAt = data.expires_at;
            IsValid = data.is_valid;
            Scopes = data.scopes;
            UserId = data.user_id;
        }
    }
}
