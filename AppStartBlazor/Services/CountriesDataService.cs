using AppStartBlazor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppStartBlazor.Services
{
    public class CountriesDataService : ICountriesDataService
    {
        private readonly HttpClient _httpClient;

        public CountriesDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Country>> GetAll()
        {
            try
            {

                return await JsonSerializer.DeserializeAsync<IEnumerable<Country>>
                    (await _httpClient.GetStreamAsync($"all"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            }
            catch (Exception ex)
            {

                throw;
            }

        }
    }
}