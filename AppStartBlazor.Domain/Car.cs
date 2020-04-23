using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppStartBlazor.Domain
{
    public class Car
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do Fabricante")]
        [StringLength(100, ErrorMessage = "Nome do Fabricante muito longo. Favor informar nome menor.")]
        public string Fabricante { get; set; }

        public string Modelo { get; set; }

        public int AnoFabricacao { get; set; }

        public float Preco { get; set; }

        public Country PaisOrigem { get; set; }

    }
}
