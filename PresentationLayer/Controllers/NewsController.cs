using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using SürdürülebilirTürkiye.DataAccessLayer;
using PresentationLayer.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace PresentationLayer.Controllers
{
    public class NewsController : Controller
    {
        private readonly Context _context;

        public NewsController(Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString, string category)
        {
            // Aktif olan tüm haber makalelerini al
            var newsQuery = _context.NewsArticles.Where(n => n.IsActive);

            // Kategori filtresi uygula (eğer belirtilmişse)
            if (!string.IsNullOrEmpty(category))
            {
                newsQuery = newsQuery.Where(n => n.Tags.Contains(category));
            }

            // Arama filtresi uygula (eğer belirtilmişse)
            if (!string.IsNullOrEmpty(searchString))
            {
                newsQuery = newsQuery.Where(n =>
                    n.Title.Contains(searchString) ||
                    n.Content.Contains(searchString));
            }

            // Filtrelenmiş ve sıralanmış sonuçları al
            var filteredNews = await newsQuery
                .OrderByDescending(n => n.PublishedDate)
                .Take(50) // Performans sorunlarını önlemek için limit koy
                .ToListAsync();

            // Kategoriler dropdown'ı için
            ViewBag.Categories = new List<string> { "Ekonomi", "Teknoloji", "Spor" };
            ViewBag.CurrentCategory = category;
            ViewBag.CurrentSearch = searchString;

            var viewModel = new NewsViewModel
            {
                LatestNews = filteredNews,
                CategorizedNews = await GetCategorizedNews()
            };

            return View(viewModel);
        }

        private async Task<List<NewsArticle>> GetCategorizedNews()
        {
            // Her kategoriden bir haber makalesi al (ilgili haberler bölümü için)
            var categorizedNews = new List<NewsArticle>();
            var categories = new List<string> { "Ekonomi", "Teknoloji", "Spor" };

            foreach (var category in categories)
            {
                var article = await _context.NewsArticles
                    .Where(n => n.IsActive && n.Tags.Contains(category))
                    .OrderByDescending(n => n.PublishedDate)
                    .FirstOrDefaultAsync();

                if (article != null)
                {
                    categorizedNews.Add(article);
                }
            }

            return categorizedNews;
        }
    }

}
