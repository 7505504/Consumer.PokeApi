using Consumer.Application.PokeApp.Interfaces;
using Consumer.Domain.Constants;
using Refit;
using System;
using System.Net.Http;

namespace Consumer.Application.PokeApp.Integrations
{
    public class PokeApiFactory : IPokeApiFactory
    {

        private readonly IHttpClientFactory _httpClientFactory;

        public PokeApiFactory(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IPokeApi CreateApi()
        {
            var httpClient = CreateHttpClientForApi();
            return RestService.For<IPokeApi>(httpClient);
        }

        public HttpClient CreateHttpClientForApi() => 
            _httpClientFactory.CreateClient(PokeApiConstants.ApiClientName);
    }
}
