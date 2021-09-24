using System;

namespace EasyMapping.Models
{
    public class PlayerModel
    {
        public int PlayerId { get; set; }
        public string Nickname { get; set; }
        public short Level { get; set; }
        public int? Age { get; set; }
        public string FirstBonusPack { get; set; }
        public DateTime? SubscriptionDate { get; set; }
    }
}
