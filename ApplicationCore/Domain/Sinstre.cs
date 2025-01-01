using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Sinstre
    {
        public int SinstreId { get; set; }
        public string Lieu { get; set; }
        public string Description { get; set; }
        public DateTime DateDeclaration  { get; set; }
        public virtual IList<Expertise> Expertises { get; set; }
        public virtual Assurance Assurance { get; set; }
        public int AssuranceFk { get; set; }
    }
}
