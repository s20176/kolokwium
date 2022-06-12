using Kolokwium1.Models;
using Kolokwium1.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kolokwium1.Services
{
    public class DbService : IDbService
    {
        private readonly MainDbContext _mainDbContext;

        public DbService(MainDbContext mainDbContext)
        {
            _mainDbContext = mainDbContext;
        }
        public async Task<MusicanDTO> getMusican(int id)
        {
            MusicanDTO musicanDTO = _mainDbContext.Musicans.Where(e => e.IdMusican == id)
                .Select(e => new MusicanDTO
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    Nickname = e.Nickname,
                    Tracks = e.Musican_Tracks.Select(t => new TrackDTO
                    {
                        Trackname = t.Track.Trackname,
                        Duration = t.Track.Duration,
                        Album = new AlbumDTO { AlbumName=t.Track.Album.AlbumName }
                    })
                }).FirstOrDefault();
            if (musicanDTO == null)
            {
                throw new Exception("Muzyk nie istnieje");
            }
            return musicanDTO;
        }

        public async Task removeMusican(int id)
        {
            MusicanDTO musican = await getMusican(id);
            if (musican == null)
            {
                throw new Exception("Nie znaleziono muzyka");
            }
            bool remove = false;
            foreach(TrackDTO track in musican.Tracks)
            {
                if (track.Album == null)
                {
                    remove = true;
                }
            }
            if (remove)
            {
                Musican m =  _mainDbContext.Musicans.Where(e => e.IdMusican == id).FirstOrDefault();
                _mainDbContext.Remove(m);
                await _mainDbContext.SaveChangesAsync();
            }
            else
            {
                throw new Exception("Wszystkie utwory muzyka pojawiły się już na albumach");
            }
        }
    }
}
