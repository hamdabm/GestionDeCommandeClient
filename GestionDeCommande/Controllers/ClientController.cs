using Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestionDeCommande.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IService<Client> clientService;

        public ClientController(IService<Client> ClientService)
        {
            clientService = ClientService;
        }

        [HttpGet]
        public List<Client> GetClient()
        {

            //var clients = clientService.GetClients();
            //var med = clients.Where(x => x.RaisonSocial == "med").ToList();
            //var majdi = clients.Where(x => x.RaisonSocial == "majdi").ToList ();


            return clientService.Get();
        }

       // [Route("/GetClient/{id}")]
     //   [HttpGet("{id}")]
        [HttpGet("{id}", Name = "GetClient")]
        public Client GetClient(int id)
        {
          return  clientService.GetById(id);
        }

        [HttpPost("AddClient")]
        public ActionResult<Client> AddClient([FromForm] Client clt)
        {
            return clientService.Add(clt);
        }

        //[Route("DeleteClient/{id}")]
        //[HttpDelete]
        [HttpDelete("{id}", Name = "DeleteClient")]

        public bool DeleteClient(int id)
        {
            return clientService.Delete(id);
        }

        [Route("UpdateClient")]
        [HttpPut]
        public Client UpdateClient(Client clt)
        {
            return clientService.Update(clt);
        }

    }
}
