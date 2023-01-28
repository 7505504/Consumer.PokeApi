using Microsoft.AspNetCore.Mvc;

namespace Consumer.Infrastructure.Handlers
{
    public class ApiKeyAttribute : ServiceFilterAttribute
    {
        public ApiKeyAttribute() : base(typeof(ApiKeyAuthorizationFilter))
        {
        }
    }
}
