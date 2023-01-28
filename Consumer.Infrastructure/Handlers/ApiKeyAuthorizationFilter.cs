using Consumer.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Consumer.Infrastructure.Handlers
{
    public class ApiKeyAuthorizationFilter : IAuthorizationFilter
    {
        private const string API_KEY_HEADER = "X-Api-Key";
        private readonly IApiKeyValidator _apiKeyValidator;

        public ApiKeyAuthorizationFilter(IApiKeyValidator apiKeyValidator)
        {
            _apiKeyValidator = apiKeyValidator;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string apiKey = context.HttpContext.Request.Headers[API_KEY_HEADER];
            if (!_apiKeyValidator.IsValid(apiKey))
                context.Result = new UnauthorizedResult();
        }
    }
}
