using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Produit
    {
        [Key]
        public int IdProd { get; set; }
        public string CodeProd { get; set; }
        public string DesignationProd { get; set; }
        public decimal PrixProd { get; set; }
        public decimal QuantiteProd { get; set; }
    }
}
