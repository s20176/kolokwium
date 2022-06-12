using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models.DTO
{
    public class TrackDTO
    {
        public string Trackname { get; set; }
        public float Duration { get; set; }
        public AlbumDTO Album { get; set; }
    }
}
