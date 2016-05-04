using System.Collections.Generic;
using MyTunesShop.Interfaces;

namespace MyTunesShop.Models.MediaFolder
{
    public class Album : Media, IAlbum
    {
        public Album(string title, decimal price,IPerformer performer, string genre, int year) 
            : base(title, price)
        {
            this.Performer = performer;
            this.Genre = genre;
            this.Year = year;
            this.Songs = new List<ISong>();
        }

        public IPerformer Performer { get; }

        public string Genre { get; }

        public int Year { get; }

        public IList<ISong> Songs { get; }

        public void AddSong(ISong song)
        {
           this.Songs.Add(song);
        }
    }
}
