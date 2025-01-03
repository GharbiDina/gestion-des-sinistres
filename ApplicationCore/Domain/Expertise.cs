﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
    public class Expertise
    {
        [DataType(DataType.DateTime, ErrorMessage = "Please enter a valid date.")]
      
        public DateTime DateExpertise { get; set; }
        [DataType(DataType.MultilineText)]

        [StringLength(100, MinimumLength = 3)]
        public string AvisTechnique { get; set; }
        public double MontantEstime { get; set; }

        public double Duree { get; set; }
        public virtual Sinstre Sinstre { get; set; }
        public virtual Expert Expert { get; set; }
        public int SinstreKey { get; set; }
        public int ExpertKey { get; set; }
        



    }
}
