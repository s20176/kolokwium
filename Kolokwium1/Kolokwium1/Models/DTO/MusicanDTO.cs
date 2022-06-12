using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Models.DTO
{
    public class MusicanDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public virtual IEnumerable<TrackDTO> Tracks { get; set; }
    }
}
