using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppStartBlazor.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AppStartBlazor.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;

        private IList<Car> listaCarros = new List<Car>();

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
            InitializeCars();
        }

        private void InitializeCars()
        {
            listaCarros = new List<Car>()
            {
                new Car(){ Id = 1, Fabricante = "Fiat", Modelo = "Uno", AnoFabricacao = 2002, Preco = 8000, PaisOrigem = new Country(){ alpha2Code = "BR", name = "Brazil" } },
                new Car(){ Id = 2, Fabricante = "Chevrolet", Modelo = "Onix", AnoFabricacao = 2018, Preco = 36000, PaisOrigem = new Country(){ alpha2Code = "BR", name = "Brazil" } }
            };
        }

        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return listaCarros;
        }

        [HttpGet("{id}")]
        public Car GetSingle(int id)
        {
            return listaCarros.FirstOrDefault(a => a.Id == id);
        }


        [HttpPost]
        public IActionResult Insert([FromBody] Car obj)
        {
            if (obj == null)
                return BadRequest();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            obj.Id = listaCarros.Max(a => a.Id) + 1;
            listaCarros.Add(obj);
            return Created("Car", obj);
        }

        [HttpPut]
        public IActionResult Update([FromBody] Car obj)
        {
            if (obj == null)
                return BadRequest();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            Car carroAlterado = listaCarros.FirstOrDefault(a => a.Id == obj.Id);

            if (carroAlterado == null)
                return NotFound();

            listaCarros.FirstOrDefault(a => a.Id == obj.Id).Fabricante = obj.Fabricante;
            listaCarros.FirstOrDefault(a => a.Id == obj.Id).Modelo = obj.Modelo;
            listaCarros.FirstOrDefault(a => a.Id == obj.Id).AnoFabricacao = obj.AnoFabricacao;
            listaCarros.FirstOrDefault(a => a.Id == obj.Id).Preco = obj.Preco;
            listaCarros.FirstOrDefault(a => a.Id == obj.Id).PaisOrigem = obj.PaisOrigem;

            return NoContent();  // sucesso
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
                return BadRequest();

            Car carroAlterado = listaCarros.FirstOrDefault(a => a.Id == id);

            if (carroAlterado == null)
                return NotFound();

            listaCarros.Remove(carroAlterado);

            return NoContent();  // sucesso
        }
    }
}
