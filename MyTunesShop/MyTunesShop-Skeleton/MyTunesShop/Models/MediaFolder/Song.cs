using System;
using System.Collections.Generic;
using MyTunesShop.Interfaces;

namespace MyTunesShop.Models.MediaFolder
{
    public class Song : Media, ISong
    {
        private static readonly int MinYear = DateTime.MinValue.Year;
        private static readonly int MaxYear = DateTime.Now.Year;

        private IPerformer performer;
        private string genre;
        private int year;
        private string duration;

        public Song(string title, decimal price, IPerformer performer, string genre, int year, string duration) 
            : base(title, price)
        {
            this.Performer = performer;
            this.Genre = genre;
            this.Year = year;
            this.Duration = duration;
            this.Ratings = new List<int>();
        }

        public IList<int> Ratings { get; }

        public IPerformer Performer
        {
            get
            {
                return this.performer;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentException("The performer of a song is required.");
                }

                this.performer = value;
            }
        }

        public string Genre
        {
            get
            {
                return this.genre;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The genre of a song is required.");
                }

                this.genre = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }

            private set
            {
                if (value < MinYear || value > MaxYear)
                {
                    throw new ArgumentException($"The year of a song must be between {MinYear} and {MaxYear}.");
                }

                this.year = value;
            }
        }

        public string Duration
        {
            get
            {
                return this.duration;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The duration of a song is required.");
                }

                this.duration = value;
            }
        }

        public void PlaceRating(int rating)
        {
            this.Ratings.Add(rating);
        }

        public override string ToString()
        {
            return this.Title;
        }
    }
}
