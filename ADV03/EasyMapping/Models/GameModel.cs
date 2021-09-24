using EasyMapping.Domain;
using EasyMapping.Mappings;

namespace EasyMapping.Models
{
    public class GameModel
        :IMapFrom<Game> // AutoMapper desteği için eklendi
    {
        public string Name { get; set; }
        public short PublishedYear { get; set; }
        public string Developers { get; set; }
    }
}
