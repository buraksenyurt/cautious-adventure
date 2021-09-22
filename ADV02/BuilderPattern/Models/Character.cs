using System.Collections.Generic;

namespace BuilderPattern.Models
{
    // Product sınıfımız
    public class Character
    {
        public string Nickname { get; set; }
        public string Location { get; set; }
        public List<Block> Blocks { get; set; } = new List<Block>();
        public void AddAbility(Block ability)
        {
            Blocks.Add(ability);
        }
    }
}
