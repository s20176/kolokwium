using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class Musican
    {
        [Key]
        public int IdMusican { get; set; }
        [MaxLength(30)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(50)]
        [Required]
        public string LastName { get; set; }
        [MaxLength(20)]
        public string Nickname { get; set; }
        public virtual ICollection<Musican_Track> Musican_Tracks { get; set; }
    }
}
