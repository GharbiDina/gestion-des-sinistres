using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Expertise
    {
        [DataType(DataType.Date, ErrorMessage = "Please enter a valid date.")]
      
        public DateTime DateExpertise { get; set; }
        [DataType(DataType.MultilineText)]

      [StringLength(3, MinimumLength = 100)]
        public string AvisTechnique { get; set; }
        public double MontantEstime { get; set; }

        public double Duree { get; set; }
        public virtual Sinstre Sinstre { get; set; }
        public virtual Expert Expert { get; set; }





    }
}
