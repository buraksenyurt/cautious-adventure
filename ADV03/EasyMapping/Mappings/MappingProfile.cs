using AutoMapper;
using EasyMapping.Domain;
using EasyMapping.Models;

namespace EasyMapping.Mappings
{
    /*
     * AutoMapper nesne dönüşümleri esnasında bir yol haritasına ihtiyaç duyar.
     * Kimi kime dönüştüreceğini bilmek için bu haritayı kullanır.
     */
    public class MappingProfile
        :Profile
    {
        // Harita Profile tipinden türeyen bir sınıfın yapıcı metodunda oluşur.
        public MappingProfile()
        {
            /*
             * Eşleştirilecek ne kadar nesne varsa burada belirtilir.
             * Ancak bu çok tercih edilen bir model değil nitekim nesne sayısı çoğaldığında burada bir sürü CreateMap çağrısı olacaktır.
             * İşte bu noktada bu sınıf bir sonraki check-in ile değişecek.
             */
            CreateMap<Player, PlayerModel>();
            CreateMap<Game, GameModel>(); 
        }
    }
}
