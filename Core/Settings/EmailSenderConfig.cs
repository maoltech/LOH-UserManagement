namespace LOH_UserManagement.User.API.Settings
{
    public class EmailSenderConfig
    {
        public const string ConfigSection = "EmailSenderConfigurations";
        public string ApiKey { get; set; }
        public string SenderName { get; set; }
        public string SenderEmail { get; set; }
    }
}
