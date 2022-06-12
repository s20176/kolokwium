using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models
{
    public class Musican_Track
    {
        public int IdTrack { get; set; }
        public int IdMusican { get; set; }
        [ForeignKey("IdTrack")]
        public virtual Track Track { get; set; }
        [ForeignKey("IdMusican")]
        public virtual Musican Musican { get; set; }
    }
}
