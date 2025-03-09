using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SürdürülebilirTürkiye.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Seeds
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Context(
                serviceProvider.GetRequiredService<DbContextOptions<Context>>()))
            {
                // Veritabanında haber var mı kontrol et
                if (context.NewsArticles.Any())
                {
                    return;   // Veritabanı zaten doldurulmuş
                }

                context.NewsArticles.AddRange(
                    new NewsArticle
                    {
                        Title = "Yenilenebilir Enerji Yatırımları Ekonomiyi Canlandırıyor",
                        Content = "Türkiye'de son 6 ayda yenilenebilir enerji yatırımları %35 artış gösterdi. Güneş ve rüzgar enerjisi projelerine yapılan yatırımlar, ekonomiye 2 milyar dolarlık katkı sağladı. Sürdürülebilir enerji kaynakları, istihdam yaratırken karbon emisyonlarının azaltılmasına da önemli katkı sağlıyor. Uzmanlar, bu yatırımların artmasıyla Türkiye'nin enerji bağımsızlığına bir adım daha yaklaştığını belirtiyor.",
                        ImageUrl = "-",
                        Author = "Ali Yılmaz",
                        PublishedDate = DateTime.Now.AddDays(-2),
                        IsActive = true,
                        Tags = "Ekonomi,Sürdürülebilirlik,Enerji"
                    },
                    new NewsArticle
                    {
                        Title = "Karbon Ayak İzi Azaltma Hedefleri Finansal Piyasaları Şekillendiriyor",
                        Content = "Küresel finans piyasalarında yeni trend: Karbon nötr yatırımlar. Büyük şirketlerin karbon ayak izini azaltma taahhütleri, borsa performanslarını olumlu etkiliyor. Son araştırmalara göre, sürdürülebilirlik hedeflerini açıklayan şirketlerin hisse değerleri ortalama %12 artış gösterdi. Yeşil tahvil ihraçları da rekor seviyeye ulaşarak, geçen yıla göre %40 büyüme kaydetti. Yatırımcılar artık sadece finansal getiriyi değil, çevresel etkileri de göz önünde bulunduruyor.",
                        ImageUrl = "-",
                        Author = "Zeynep Kaya",
                        PublishedDate = DateTime.Now.AddDays(-3),
                        IsActive = true,
                        Tags = "Ekonomi,Finans,Karbon Ayak İzi"
                    },
                    new NewsArticle
                    {
                        Title = "Yapay Zeka ile Karbon Emisyonları Takibi Kolaylaşıyor",
                        Content = "Türk girişimciler tarafından geliştirilen yeni bir yapay zeka teknolojisi, şirketlerin karbon emisyonlarını gerçek zamanlı olarak takip etmelerini sağlıyor. Bulut tabanlı yazılım, enerji tüketimi, üretim süreçleri ve tedarik zinciri verilerini analiz ederek, karbon ayak izini hesaplıyor ve azaltma stratejileri öneriyor. Sistem, uluslararası sertifikasyon standartlarına uyumlu raporlar hazırlayarak, şirketlerin sürdürülebilirlik hedeflerine ulaşmalarını kolaylaştırıyor.",
                        ImageUrl = "-",
                        Author = "Mehmet Kaya",
                        PublishedDate = DateTime.Now.AddDays(-1),
                        IsActive = true,
                        Tags = "Teknoloji,Yapay Zeka,Karbon Ayak İzi"
                    },
                    new NewsArticle
                    {
                        Title = "Yeşil Yazılım Geliştirme: Çevre Dostu Kod Yazmanın Esasları",
                        Content = "Yazılım sektöründe yeni bir akım: Yeşil kodlama. Daha az enerji tüketen, sunucu yükünü azaltan ve karbon emisyonlarını düşüren yazılım geliştirme teknikleri giderek yaygınlaşıyor. Araştırmalar, optimize edilmiş kod ve verimli algoritmalar sayesinde bir yazılımın enerji tüketiminin %70'e kadar azaltılabileceğini gösteriyor. Özellikle bulut tabanlı uygulamalarda bu yaklaşım, büyük veri merkezlerinin karbon ayak izinin azaltılmasına önemli katkı sağlıyor.",
                        ImageUrl = "-",
                        Author = "Ahmet Şahin",
                        PublishedDate = DateTime.Now.AddDays(-4),
                        IsActive = true,
                        Tags = "Teknoloji,Yazılım,Sürdürülebilirlik"
                    },
                    new NewsArticle
                    {
                        Title = "Spor Kulüpleri Sürdürülebilirlik Sözleşmesi İmzaladı",
                        Content = "Türkiye'nin önde gelen spor kulüpleri, karbon ayak izini azaltmak için ortak bir sözleşme imzaladı. Stadyumlarda yenilenebilir enerji kullanımı, plastik atık azaltma ve su tasarrufu programları başlatan kulüpler, taraftarları da sürece dahil ediyor. Maçlara toplu taşıma veya bisikletle gelen taraftarlara özel indirimler sağlanırken, stadyumlardaki gıda atıklarının kompost yapılması planlanıyor. Bu girişim, Avrupa'daki benzer uygulamalardan esinlenerek geliştirildi.",
                        ImageUrl = "-",
                        Author = "Ayşe Demir",
                        PublishedDate = DateTime.Now,
                        IsActive = true,
                        Tags = "Spor,Futbol,Sürdürülebilirlik"
                    },
                    new NewsArticle
                    {
                        Title = "Bisiklet Sporunda Çevre Dostu Ekipman Devrimi",
                        Content = "Bisiklet endüstrisi, sürdürülebilir malzemelerle üretilen ekipmanlarla devrim yaratıyor. Geri dönüştürülmüş karbon fiber, biyoplastik ve doğal elyaflardan üretilen bisiklet parçaları, hem performans hem de çevre dostu özellikleriyle dikkat çekiyor. Yerli bir üretici, atık plastik şişelerden ürettiği bisiklet formalarıyla büyük ilgi görüyor. Bu yenilikçi yaklaşım, profesyonel takımlar tarafından da benimseniyor ve sektördeki karbon ayak izinin azaltılmasına katkı sağlıyor.",
                        ImageUrl = "-",
                        Author = "Can Yıldız",
                        PublishedDate = DateTime.Now.AddDays(-5),
                        IsActive = true,
                        Tags = "Spor,Bisiklet,Çevre"
                    },
                    new NewsArticle
                    {
                        Title = "Yeşil Binalar İnşaat Sektörünü Dönüştürüyor",
                        Content = "Türkiye'de LEED ve BREEAM sertifikalı yeşil bina sayısı son bir yılda %25 arttı. Enerji verimli, su tasarruflu ve düşük karbonlu yapıların ekonomik getirileri de dikkat çekiyor. Araştırmalar, yeşil binaların işletme maliyetlerinde %30'a varan tasarruf sağladığını ve daha yüksek kira gelirleri getirdiğini gösteriyor. İnşaat sektöründeki bu dönüşüm, şehirlerin sürdürülebilirlik hedeflerine ulaşmasında önemli rol oynuyor.",
                        ImageUrl = "-",
                        Author = "Selin Yılmaz",
                        PublishedDate = DateTime.Now.AddDays(-6),
                        IsActive = true,
                        Tags = "Ekonomi,İnşaat,Sürdürülebilirlik"
                    },
                    new NewsArticle
                    {
                        Title = "Tarımda Akıllı Sulama Sistemleri Su Tasarrufu Sağlıyor",
                        Content = "Çiftçiler, toprak nem sensörleri ve hava durumu verilerini kullanan akıllı sulama sistemleriyle su tüketimini %40 azaltıyor. IoT teknolojisiyle geliştirilen bu sistemler, cep telefonundan kontrol edilebiliyor ve sadece gereken miktarda suyun kullanılmasını sağlıyor. Küresel iklim değişikliğiyle mücadelede önemli rol oynayan bu teknoloji, çiftçilere ekonomik fayda sağlarken, su kaynaklarının korunmasına da katkıda bulunuyor.",
                        ImageUrl = "-",
                        Author = "Hakan Demir",
                        PublishedDate = DateTime.Now.AddDays(-7),
                        IsActive = true,
                        Tags = "Teknoloji,Tarım,Çevre"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}