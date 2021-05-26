using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Client
    {
        [Key]
        public int CltId { get; set; }
        public string CodeClt { get; set; }
        public string RaisonSocial { get; set; }
        public string Adresse { get; set; }
        public string Tel { get; set; }
        
    }
}
