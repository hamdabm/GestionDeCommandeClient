
using System.Collections.Generic;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace GestionDeCommande.Controllers
{


        [Route("api/[controller]")]
        [ApiController]
        public class ProduitController : ControllerBase
        {
        private readonly IService<Produit> produitService;

        public ProduitController(IService<Produit> ProduitService)
            {
            produitService = ProduitService;
        }

            [HttpGet]
            public List<Produit> GetProduit()
            {                
            return produitService.Get();
            }

            [HttpGet("{id}", Name = "GetProduit")]
            public Produit GetProduit(int id)
            {
                return produitService.GetById(id);
            }

            [HttpPost("AddProduit")]
            public ActionResult<Produit> AddProduit( Produit prod)
            {
                return produitService.Add(prod);
            }

            [Route("DeleteProduit/{id}")]
            [HttpDelete]
            public bool DeleteProduit(int id)
            {
                return produitService.Delete(id);
            }

            [Route("UpdateProduit")]
            [HttpPut]
            public Produit UpdateProduit(Produit prod)
            {
                return produitService.Update(prod);
            }

        }
 


}
