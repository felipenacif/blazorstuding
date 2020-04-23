using AppStartBlazor.Domain;
using AppStartBlazor.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppStartBlazor.Pages
{
    public class CarEditBase : ComponentBase
    {
        [Inject]
        public ICarsDataService CarsDataService { get; set; }

        [Inject]
        public ICountriesDataService CountriesDataService { get; set; }

        [Parameter]
        public string IdCarro { get; set; }



        public Car carro { get; set; } = new Car();
        public IEnumerable<Country> paises { get; set; } = new List<Country>();


        public string StatusClass { get; private set; }
        public string Message { get; private set; }
        public bool Saved { get; private set; }



        protected string alpha2Code = string.Empty;




        protected override async Task OnInitializedAsync()
        {
            paises = await CountriesDataService.GetAll();

            if(!string.IsNullOrEmpty(IdCarro))
            {
                carro = await CarsDataService.GetSingleCar(IdCarro);
                alpha2Code = carro.PaisOrigem.alpha2Code;
            }
        }

        protected async Task SubmitForm()
        {
            carro.PaisOrigem = paises.FirstOrDefault(a => a.alpha2Code == alpha2Code);

            if (carro.Id == 0)
            {
                var objetoAdicionado = await CarsDataService.AddCar(carro);
                if(objetoAdicionado.Id > 0)
                {
                    StatusClass = "alert-success";
                    Message = "Carro adicionado com sucesso";
                    Saved = true;
                }
                else
                {
                    StatusClass = "alert-danger";
                    Message = "Houve um erro ao incluir o carro novo";
                    Saved = false;
                }
            }
            else
            {
                await CarsDataService.UpdateCar(carro);

                StatusClass = "alert-success";
                Message = "Carro alterado com sucesso";
                Saved = true;
            }
        }

    }
}
