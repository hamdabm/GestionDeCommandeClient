using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CommandeEntete
    {
        [Key]
        public int IdCmdEnt { get; set; }
        public DateTime DateCmd { get; set; }
        public string NumeroCmd { get; set; }
        public decimal MontantTot { get; set; }
        public Client Client { get; set; }
        public int IdClt { get; set; }
        public ICollection<CommandeLigne> CommandeLignes { get; set; }
    }
}
