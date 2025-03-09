using EntityLayer.Concrete;

namespace PresentationLayer.ViewModels
{
    public class NewsViewModel
    {
        public List<NewsArticle> LatestNews { get; set; }
        public List<NewsArticle> CategorizedNews { get; set; }
    }
}
