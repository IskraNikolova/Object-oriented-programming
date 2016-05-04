using System;
using MyTunesShop.Interfaces;

namespace MyTunesShop.Models.MediaFolder
{
    public abstract class Media : IMedia
    {
        private string title;
        private decimal price;

        protected Media(string title, decimal price)
        {
            this.title = title;
            this.price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("The title of a song is required.");
                }

                this.title = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The price of a song must be non-negative.");
                }

                this.price = value;
            }
        }

    }
}
