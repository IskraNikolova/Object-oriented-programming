using System.Text;

namespace BookShop.Models
{
    using System;

    public class Book
    {
        private string author;
        private string title;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public string Author
        {
            get
            {
                return this.author;
            }
            set
            {
                var twoNames = value.Split();

                if (twoNames.Length > 1)
                {
                    if (!string.IsNullOrEmpty(twoNames[1]))
                    {
                        if (char.IsNumber(twoNames[1][0]))
                        {
                            throw new ArgumentException("Author not valid!");
                        }
                    }
                }

                this.author = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }

                this.title = value;
            }
        }

        public virtual decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Type: {this.GetType().Name}");
            output.AppendLine($"Title: {this.Title}");
            output.AppendLine($"Author: {this.Author}");
            output.AppendLine($"Price: {this.Price:F1}");

            return output.ToString();
        }
    }
}
