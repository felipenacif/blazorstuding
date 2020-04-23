using AppStartBlazor.Domain;
using AppStartBlazor.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppStartBlazor.Components
{
    public class AddCarWidgetBase : ComponentBase
    {
        [Inject]
        public ICarsDataService CarsDataService { get; set; }

        [Parameter]
        public EventCallback<bool> CloseEventCallback { get; set; }


        public Car carro { get; set; } = new Car();
        public IEnumerable<Country> paises { get; set; } = new List<Country>();


        public bool ShowDialog { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged();
        }

        public void Close()
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            carro = new Car() { Id = 1, Fabricante = "Teste" };
        }

        protected async Task SubmitForm()
        {
            await CarsDataService.AddCar(carro);
            await CloseEventCallback.InvokeAsync(true);
            ShowDialog = false;

            StateHasChanged();

        }
    }
}
