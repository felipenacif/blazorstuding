using AppStartBlazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppStartBlazor.Pages
{
    public class CarsBase : ComponentBase
    {
        public IEnumerable<AppStartBlazor.Domain.Car> ListaCars { get; set; }

        public CarsBase()
        {

        }


        [Inject]
        public ICarsDataService CarsDataService { get; set; }


        protected override async Task OnInitializedAsync()
        {
            ListaCars = await CarsDataService.GetAllCars();
            //return await base.OnInitializedAsync();
        }



    }
}
