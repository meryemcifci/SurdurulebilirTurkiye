using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NewsArticle
    {
        public int Id { get; set; } // Primary Key
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public string Author { get; set; }
        public DateTime PublishedDate { get; set; }
        public bool IsActive { get; set; }
        public string Tags { get; set; }

        public ICollection<News> RelatedNews { get; set; }
    }
}
