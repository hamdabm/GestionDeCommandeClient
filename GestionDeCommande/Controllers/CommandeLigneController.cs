using System.Collections.Generic;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace GestionDeCommande.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class CommandeLigneController : ControllerBase
    {
        private readonly IService<CommandeLigne> _commandeLigneService;

        public CommandeLigneController(IService<CommandeLigne> commandeLigneService)
        {
            this._commandeLigneService = commandeLigneService;
        }

        [HttpGet]
        public List<CommandeLigne> GetCommandeLigne()
        {
            return _commandeLigneService.Get();
        }

        // [Route("/GetCommandeLigne/{id}")]
        //   [HttpGet("{id}")]
        [HttpGet("{id}", Name = "GetCommandeLigne")]
        public CommandeLigne GetCommandeLigne(int id)
        {
            return _commandeLigneService.GetById(id);
        }

        [HttpPost("AddCommandeLigne")]
        public ActionResult<CommandeLigne> AddCommandeLigne( CommandeLigne cmdlig)
        {
            return _commandeLigneService.Add(cmdlig);
        }

        [Route("DeleteCommandeLigne/{id}")]
        [HttpDelete]
        public bool DeleteCommandeLigne(int id)
        {
            return _commandeLigneService.Delete(id);
        }

        [Route("UpdateCommandeLigne")]
        [HttpPut]
        public CommandeLigne UpdateCommandeLigne(CommandeLigne cmde)
        {
            return _commandeLigneService.Update(cmde);
        }

    }



}
