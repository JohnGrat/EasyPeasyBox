namespace EasyPeasyBox.Frontend.Services
{
    public class ConfService
    {
        private readonly IConfiguration _configuration;

        public ConfService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetFrontendBaseUrl()
        {
            return _configuration["Frontend:BaseUrl"];
        }
    }
}
