using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class Musiclabel
    {
        [Key]
        public int IdMusicLabel { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
