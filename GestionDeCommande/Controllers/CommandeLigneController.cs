using System;
using System.Collections.Generic;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Implementations;

namespace GestionDeCommande.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CommandeLigneController : ControllerBase
    {
        private readonly CommandeLigneService commandeLigneService;

        public CommandeLigneController(CommandeLigneService CommandeLigneService)
        {
            commandeLigneService = CommandeLigneService;
        }

        [HttpGet]
        public List<CommandeLigne> GetCommandeLigne()
        {
            return commandeLigneService.GetCommandeLignes();
        }

        // [Route("/GetCommandeLigne/{id}")]
        //   [HttpGet("{id}")]
        [HttpGet("{id}", Name = "GetCommandeLigne")]
        public CommandeLigne GetCommandeLigne(int id)
        {
            return commandeLigneService.GetCommandeLigneById(id);
        }

        [HttpPost("AddCommandeLigne")]
        public ActionResult<CommandeLigne> AddCommandeLigne([FromForm] CommandeLigne cmde)
        {
            return commandeLigneService.AddCommandeLigne(cmde);
        }

        [Route("DeleteCommandeLigne/{id}")]
        [HttpDelete]
        public bool DeleteCommandeLigne(int id)
        {
            return commandeLigneService.DeleteCommandeLigne(id);
        }

        [Route("UpdateCommandeLigne")]
        [HttpPut]
        public CommandeLigne UpdateCommandeLigne(CommandeLigne cmde)
        {
            return commandeLigneService.UpdateCommandeLigne(cmde);
        }

    }



}
