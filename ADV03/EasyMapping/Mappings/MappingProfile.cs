using AutoMapper;
using EasyMapping.Domain;
using EasyMapping.Models;
using System;
using System.Linq;
using System.Reflection;

namespace EasyMapping.Mappings
{
    /*
     * AutoMapper nesne dönüşümleri esnasında bir yol haritasına ihtiyaç duyar.
     * Kimi kime dönüştüreceğini bilmek için bu haritayı kullanır.
     */
    public class MappingProfile
        : Profile
    {
        //// Harita Profile tipinden türeyen bir sınıfın yapıcı metodunda oluşur.
        //public MappingProfile()
        //{
        //    /*
        //     * Eşleştirilecek ne kadar nesne varsa burada belirtilir.
        //     * Ancak bu çok tercih edilen bir model değil nitekim nesne sayısı çoğaldığında burada bir sürü CreateMap çağrısı olacaktır.
        //     * İşte bu noktada bu sınıf bir sonraki check-in ile değişecek.
        //     */
        //    CreateMap<Player, PlayerModel>();
        //    CreateMap<Game, GameModel>(); 
        //}

        /*
         * Büyük ihtimalle aşağıdaki kısmı copy-paste yaparak kullanıyoruz.
         * Ama özünde generic IMapFrom interface tipini uygulayan sınıfların tarandığını
         * ve her biri için Mapping fonksiyonunu çağırıldığını ifade edebiliriz
         * ki hem PlayerModel hem GameModel IMapFrom<T> arayüzünü uyguluyor.
         * 
         * Burayı daha iyi anlamak için Reflection konusuna bir bakmak lazım. 
         * GetMethod ve GetInterface çağrılarına gelene kadar çalışma zamanındaki Assembly'ın arayüzleri taranmakta ve koşula uyanlar üstünde dolaşılırken birerde örneği CreateInstance ile oluşturulmakta, neden?
         * 
         * Hatta sonrasında bu nesne örneği üstünden Mapping metodu çağırılıyor, neden?
         */
        public MappingProfile()
        {
            var types = Assembly.GetExecutingAssembly().GetExportedTypes()
                .Where(t => t.GetInterfaces().Any(i =>
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
                .ToList();

            foreach (var type in types)
            {
                var instance = Activator.CreateInstance(type);
                var methodInfo = type.GetMethod("Mapping") ??
                                 type.GetInterface("IMapFrom`1").GetMethod("Mapping");
                methodInfo?.Invoke(instance, new object[] { this });
            }
        }
    }
}
