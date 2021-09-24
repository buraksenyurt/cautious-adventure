using AutoMapper;
using EasyMapping.Domain;
using EasyMapping.Models;
using System;
using System.Collections.Generic;

namespace EasyMapping.Services
{
    public class PlayerService
        : IPlayerService
    {
        /*
         * AutoMapper'ı bir bileşende kullanmak istersek IMapper arayüzünü enjekte etmemiz yeterlidir.
         * 
         * GetPlayers metodu PlayerModel ile çalışyor. Domain içerisinde ise Player nesnesinin dolaştığını düşünüyoruz.
         * Dolayısıyla Player nesnelerinin listesini çektikten sonra onları PlayerModel'e dönüştürmemiz gerekir ki...
         */
        private readonly IMapper _mapper;
        public PlayerService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public List<PlayerModel> GetPlayers()
        {
            // Aşağıdaki oyuncu listesinin bir veri kaynağından geldiğini düşünelim tabii ki. Ama presentation tarafına bu içeriğin her bilgisini de vermek istemiyoruz.
            var players = new List<Player>
            {
                new Player{ PlayerId=1001, Nickname="Furiyın", Age=45,FirstBonusPack="Gold", Level=200, SubscriptionDate=DateTime.Now },
                new Player{ PlayerId=1002, Nickname="Mendo", Age=41,FirstBonusPack="Platin", Level=600, SubscriptionDate=DateTime.Now.AddYears(-10) },
                new Player{ PlayerId=1003, Nickname="Enci", Age=45,FirstBonusPack="Silver", Level=100, SubscriptionDate=DateTime.Now },
            };

            return _mapper.Map<List<PlayerModel>>(players); //.. o da bu kadar kolaydı aslında. Örneğin PlayerModel nesnelerinde SubscriptionDate ve FirstBonusPack bilgileri yok. AutoMapper onları atlamasını bilecek.
        }
    }
}
