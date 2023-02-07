using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_eamado.Models
{
    public class FanMailModel
    {
        [Range(0, 100, ErrorMessage = "The value must be between 0 and 100")]
        public int Calc1 { get; set; }
        [Range(0, 100, ErrorMessage = "The value must be between 0 and 100")]
        public int Calc2 { get; set; }
        [Range(0, 100, ErrorMessage = "The value must be between 0 and 100")]
        public int Calc3 { get; set; }
        [Range(0, 100, ErrorMessage = "The value must be between 0 and 100")]
        public int Calc4 { get; set; }
        [Range(0, 100, ErrorMessage = "The value must be between 0 and 100")]
        public int Calc5 { get; set; }
        [Range(0, 100, ErrorMessage = "The value must be between 0 and 100")]
        public int Calc6 { get; set; }
        [Range(0, 100, ErrorMessage = "The value must be between 0 and 100")]
        public int Calc7 { get; set; }
    }
}



