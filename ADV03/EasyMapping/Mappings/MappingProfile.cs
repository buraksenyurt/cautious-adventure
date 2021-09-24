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
            // Eşleştirilecek ne kadar nesne varsa burada belirtilir.
            CreateMap<Player, PlayerModel>();
        }
    }
}
