using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.DTOs
{
    public class DinoUpdateDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Period { get; set; }

        [Required]
        public string Diet { get; set; }
    }
}
