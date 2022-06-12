using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class Album
    {
        [Key]
        public int IdAlbum { get; set; }
        [MaxLength(30)]
        [Required]
        public string AlbumName { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }
        public int IdMusiclabel { get; set; }
        [ForeignKey("IdMusiclabel")]
        public virtual Musiclabel Musiclabel { get; set; }
    }
}
