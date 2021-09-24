using AutoMapper;
using EasyMapping.Domain;
using EasyMapping.Mappings;
using System;

namespace EasyMapping.Models
{
    public class PlayerModel
        : IMapFrom<Player> // AutoMapper desteği için eklendi.
    {
        public int PlayerId { get; set; }
        public string Nickname { get; set; }
        public short Level { get; set; }
        public int? Age { get; set; }

        /* 
         * Aşağıdaki özellikleri vermek istemediğimizi düşünelim.
         * Bir Mapping fonskiyonu yazarak da ilerleyebiliriz.
         * Bilin bakalım o Mapping fonksiyonunu kim nasıl çağırıyor.
         */
        public string FirstBonusPack { get; set; }
        public DateTime? SubscriptionDate { get; set; }

        public void Mapping(Profile profile)
        {
            var c = profile
                .CreateMap<Player, PlayerModel>()
                .ForMember(p => p.SubscriptionDate, opt => opt.Ignore())
                .ForMember(p => p.FirstBonusPack, opt => opt.Ignore());
        }
    }
}
