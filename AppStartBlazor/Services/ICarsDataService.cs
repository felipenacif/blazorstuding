using AppStartBlazor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppStartBlazor.Services
{
    public interface ICarsDataService
    {
        Task<IEnumerable<Car>> GetAllCars();
        Task<Car> GetSingleCar(string idCarro);
        Task<Car> AddCar(Car carro);
        Task UpdateCar(Car carro);
        Task DeleteCar(int idCarro);
    }
}
