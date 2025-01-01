using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Expert
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string EmailAddress { get; set; }
        public string tel { get; set; }
        public string DomaineExpert { get; set; }
        public double TarifErr { get; set; }
        public virtual IList<Expertise> Expertises { get; set; }



    }
}
