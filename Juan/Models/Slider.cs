using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Juan.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Required]
        [MaxLength(250)]
        public string Desc { get; set; }
        [MaxLength(250)]
        public string BtnText { get; set; }
        [MaxLength(250)]
        public string BtnUrl { get; set; }
        public string Image { get; set; }
        public int Order { get; set; }
    }
}
