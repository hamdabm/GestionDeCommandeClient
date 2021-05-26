using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models 
{ 
    public class CommandeLigne
    {
        [Key]
        public int IdCmdLigne { get; set; }
        public decimal PrixProd { get; set; }
        public DateTime DateLigne { get; set; }
        public decimal QteLigne { get; set; }
        public int IdCmdEnt { get; set; }
        public CommandeEntete CommandeEntete { get; set; }
        public Produit Produit { get; set; }
        public int IdProd { get; set; }

    }
}
