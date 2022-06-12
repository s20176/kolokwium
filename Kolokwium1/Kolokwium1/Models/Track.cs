using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class Track
    {
        [Key]
        public int IdTrack { get; set; }
        [MaxLength(20)]
        [Required]
        public string Trackname { get; set; }
        [Required]
        public float Duration { get; set; }
        public int IdMusicAlbum { get; set; }
        [ForeignKey("IdMusicAlbum")]
        public virtual Album Album { get; set; }
        public virtual ICollection<Musican_Track> Musican_Tracks { get; set; }
    }
}
