using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{public enum TypeAssurance
    {
        Voiture,Habitation,Sente,Vie
    }
    public class Assurance
    {
        public int AssuranceId { get; set; }
       
        [Display(Name = "DateEffet")]
        public DateTime DateEffet { get; set; }
        [Display(Name = "DateEcheance")]
        public DateTime DateEcheance { get; set; }
        public TypeAssurance typeAssurance { get; set; }
        public virtual IList<Sinstre> Sinstre { get; set; }
    }
}
