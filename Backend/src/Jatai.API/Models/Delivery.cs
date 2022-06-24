using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jatai.API.Models
{
    public class Delivery
    {
        public int Id { get; set; }

        // Dados de Coleta
        public int ZipCollect { get; set; }
        public string AdressCollect { get; set; }
        public int NumberAdressCollect { get; set; }
        public string ComplementCollect { get; set; }
        public string DistrictCollect { get; set; }
        public string CityCollect { get; set; }

        // Dados de Entrega
        public int ZipDelivery { get; set; }
        public string AdressDelivery { get; set; }
        public int NumberAdressDelivery { get; set; }
        public string ComplementDelivery { get; set; }
        public string DistrictDelivery { get; set; }
        public string CityDelivery { get; set; }

        // Dados Adicionais
        public bool Return { get; set; }

        // Dados Pessoais
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
    }
}