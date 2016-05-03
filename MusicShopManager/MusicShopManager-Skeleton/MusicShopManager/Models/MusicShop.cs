using System;
using System.Linq;
using System.Text;
using MusicShop.Interfaces;

namespace MusicShop.Models
{
    using System.Collections.Generic;

    public class MusicShop : IMusicShop
    {
        private string name;

        public MusicShop(string name)
        {
            this.Name = name;
            this.Articles = new List<IArticle>();
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name is required");
                }

                this.name = value;
            }
        }

        public IList<IArticle> Articles { get; }

        public void AddArticle(IArticle article)
        {
            this.Articles.Add(article);
        }

        public void RemoveArticle(IArticle article)
        {
            this.Articles.Remove(article);
        }

        public string ListArticles()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"===== {this.Name} =====");

            if (!this.Articles.Any())
            {
                sb.AppendLine("The shop is empty. Come back soon.");
                return sb.ToString();
            }
            var microphones = this.Articles.Where(a => a is IMicrophone).OrderBy(a => a.Make + " " + a.Model);
            sb.Append(this.PrintArticles(microphones, "Microphones"));

            var drums = this.Articles.Where(a => a is IDrums).OrderBy(a => a.Make + " " + a.Model);
            sb.Append(this.PrintArticles(drums, "Drums"));

            var electricGuitars = this.Articles.Where(a => a is IElectricGuitar).OrderBy(a => a.Make + " " + a.Model);
            sb.Append(this.PrintArticles(electricGuitars, "Electric guitars"));

            var acousticGuitars = this.Articles.Where(a => a is IAcousticGuitar).OrderBy(a => a.Make + " " + a.Model);
            sb.Append(this.PrintArticles(acousticGuitars, "Acoustic guitars"));

            var bassGuitars = this.Articles.Where(a => a is IBassGuitar).OrderBy(a => a.Make + " " + a.Model);
            sb.Append(this.PrintArticles(bassGuitars, "Bass guitars"));


            return sb.ToString();
    }

    private string PrintArticles(IEnumerable<IArticle> articles, string title)
        {
            if (articles.Count() == 0)
            {
                return string.Empty;
            }

            StringBuilder articlesAsString = new StringBuilder();
            articles = articles.OrderBy(a => a.Make + " " + a.Model);
            articlesAsString.AppendFormat("{0} {1} {0}", new string('-', 5), title).AppendLine();
            foreach (var article in articles)
            {
                articlesAsString.Append(article.ToString());
            }

            return articlesAsString.ToString();
        }
    }
}
