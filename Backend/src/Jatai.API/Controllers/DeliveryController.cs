using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jatai.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Jatai.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DeliveryController : ControllerBase
    {
        public DeliveryController()
        {
        }

        [HttpGet]
        public Delivery Get()
        {
            return new Delivery()
            {

                Id = 1,
                AdressCollect = "Rua A",
                CityCollect = "Canoas",
                ComplementCollect = "Perto da Árvore",
                DistrictCollect = "Vila Sapo",
                NumberAdressCollect = 1234,
                ZipCollect = 12345678,
                AdressDelivery = "Rua B",
                CityDelivery = "Porto Alegre",
                ComplementDelivery = "Perto do Poste",
                DistrictDelivery = "Morro da Tuca",
                NumberAdressDelivery = 4321,
                ZipDelivery = 87654321,
                Name = "Teu Pai de Calcinha",
                Company = "Vipal",
                Email = "vipal@email.com",
                Phone = 34556677,
                Return = false
            };
        }
        [HttpPost]
        public string Post()
        {
            return "Teste Post";
        }
        [HttpPut("{id}")]
        public string Put(Guid Id)
        {
            return $"Teste Put id = {Id}";
        }
        [HttpDelete("{id}")]
        public string Delete(Guid Id)
        {
            return $"Teste Delete id = {Id}";
        }
    }
}
