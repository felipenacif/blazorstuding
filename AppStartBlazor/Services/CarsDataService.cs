using AppStartBlazor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppStartBlazor.Services
{
    public class CarsDataService : ICarsDataService
    {
        private readonly HttpClient _httpClient;

        public CarsDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Car> AddCar(Car carro)
        {
            var carroJson = new StringContent(JsonSerializer.Serialize(carro), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"api/cars", carroJson);

            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Car>(await response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task<IEnumerable<Car>> GetAllCars()
        {
            try
            {

                return await JsonSerializer.DeserializeAsync<IEnumerable<Car>>
                    (await _httpClient.GetStreamAsync($"api/cars"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        public async Task<Car> GetSingleCar(string idCarro)
        {
            try
            {

                return await JsonSerializer.DeserializeAsync<Car>
                    (await _httpClient.GetStreamAsync($"api/cars/{idCarro}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task UpdateCar(Car carro)
        {
            var carroJson = new StringContent(JsonSerializer.Serialize(carro), Encoding.UTF8, "application/json");

            await _httpClient.PutAsync($"api/cars", carroJson);
        }


        public async Task DeleteCar(int idCarro)
        {
            await _httpClient.DeleteAsync($"api/cars/{idCarro}");
        }
    }
}
