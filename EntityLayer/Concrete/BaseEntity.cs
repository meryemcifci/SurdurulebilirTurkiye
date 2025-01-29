using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }  // Tüm entity'lerde bir Id alanı olacak
        public string UserId { get; set; }  // Kullanıcı bazlı veri için
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;  // Kayıt zamanı
    }
}
