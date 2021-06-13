using System.Collections.Generic;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace GestionDeCommande.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CommandeEnteteController : ControllerBase
    {
        private readonly IService<CommandeEntete> _commandeEnteteService;

        public CommandeEnteteController(IService<CommandeEntete> commandeEnteteService)
        {
            this._commandeEnteteService = commandeEnteteService;
        }

        [HttpGet]
        public List<CommandeEntete> GetCommandeEntete()
        {
            return _commandeEnteteService.Get();
        }

        // [Route("/GetCommandeEntete/{id}")]
        //   [HttpGet("{id}")]
        [HttpGet("{id}", Name = "GetCommandeEntete")]
        public CommandeEntete GetCommandeEntete(int id)
        {
            return _commandeEnteteService.GetById(id);
        }

        [HttpPost("AddCommandeEntete")]
        public ActionResult<CommandeEntete> AddCommandeEntete(CommandeEntete cmde)
        {
            return _commandeEnteteService.Add(cmde);
        }

        [Route("DeleteCommandeEntete/{id}")]
        [HttpDelete]
        public bool DeleteCommandeEntete(int id)
        {
            return _commandeEnteteService.Delete(id);
        }

        [Route("UpdateCommandeEntete")]
        [HttpPut]
        public CommandeEntete UpdateCommandeEntete(CommandeEntete cmde)
        {
            return _commandeEnteteService.Update(cmde);
        }

    }



}
