using System.Collections.Generic;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Implementations;

namespace GestionDeCommande.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CommandeEnteteController : ControllerBase
    {
        private readonly CommandeEnteteService commandeEnteteService;

        public CommandeEnteteController(CommandeEnteteService CommandeEnteteService)
        {
            commandeEnteteService = CommandeEnteteService;
        }

        [HttpGet]
        public List<CommandeEntete> GetCommandeEntete()
        {
            return commandeEnteteService.GetCommandeEntetes();
        }

        // [Route("/GetCommandeEntete/{id}")]
        //   [HttpGet("{id}")]
        [HttpGet("{id}", Name = "GetCommandeEntete")]
        public CommandeEntete GetCommandeEntete(int id)
        {
            return commandeEnteteService.GetCommandeEnteteById(id);
        }

        [HttpPost("AddCommandeEntete")]
        public ActionResult<CommandeEntete> AddCommandeEntete([FromForm] CommandeEntete cmde)
        {
            return commandeEnteteService.AddCommandeEntete(cmde);
        }

        [Route("DeleteCommandeEntete/{id}")]
        [HttpDelete]
        public bool DeleteCommandeEntete(int id)
        {
            return commandeEnteteService.DeleteCommandeEntete(id);
        }

        [Route("UpdateCommandeEntete")]
        [HttpPut]
        public CommandeEntete UpdateCommandeEntete(CommandeEntete cmde)
        {
            return commandeEnteteService.UpdateCommandeEntete(cmde);
        }

    }



}
