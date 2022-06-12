using Kolokwium1.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Services
{
    public interface IDbService
    {
        public Task<MusicanDTO> getMusican(int id);
        public Task removeMusican(int id);
    }
}
