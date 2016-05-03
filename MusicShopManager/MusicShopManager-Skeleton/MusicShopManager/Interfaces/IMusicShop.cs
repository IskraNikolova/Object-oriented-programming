using System.Collections.Generic;

namespace MusicShop.Interfaces
{
    public interface IMusicShop
    {
        string Name { get; }

        IList<IArticle> Articles { get; }

        void AddArticle(IArticle article);

        void RemoveArticle(IArticle article);

        string ListArticles();
    }
}
