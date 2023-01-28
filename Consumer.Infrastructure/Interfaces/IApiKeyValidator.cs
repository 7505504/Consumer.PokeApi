namespace Consumer.Infrastructure.Interfaces
{
    public interface IApiKeyValidator
    {
        bool IsValid(string apiKey);
    }
}