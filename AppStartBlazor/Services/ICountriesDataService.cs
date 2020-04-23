using AppStartBlazor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppStartBlazor.Services
{
    public interface ICountriesDataService
    {
        Task<IEnumerable<Country>> GetAll();
    }
}
