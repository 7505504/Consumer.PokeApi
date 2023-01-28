using Consumer.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Consumer.Infrastructure.Handlers
{
    public class ApiKeyValidator : IApiKeyValidator
    {
        private readonly IConfiguration Configuration;
        private const string API_KEY_NAME = "X-Api-Key-Mock";

        public ApiKeyValidator(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public bool IsValid(string apiKey)
        {
            string? apiKeyMock = Configuration["X-Api-Key-Mock"];

            if (string.Equals(apiKey, apiKeyMock))
                return true;

            return false;
        }
    }
}
