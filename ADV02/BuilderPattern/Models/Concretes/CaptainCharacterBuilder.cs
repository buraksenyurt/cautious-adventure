using BuilderPattern.Models.Contracts;
using BuilderPattern.Models.Product;

namespace BuilderPattern.Models.Concretes
{
    // Builder sözleşmesini uygulayan asıl sınıf(Concrete Builder)
    public class CaptainCharacterBuilder
        : ICharacterBuilder
    {
        public Character Character { get; set; } = new Character();
        public CaptainCharacterBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            Character = new Character() { Nickname = "Yüzbaşı", Location = "Ay" };
        }
        public Character GetCharacter()
        {
            Character result = this.Character;
            Reset();
            return result;
        }
        public void BuildBody()
        {
            Character.AddAbility(new Block
            {
                Name = "Kevler Zırh",
                Level = 800,
                Description = "Işın geçirmez çelik zırh. Her seviyedeki ışınlara karşı koruma sağlar."
            });
        }
        public void BuildLeftArm()
        {
            Character.AddAbility(new Block
            {
                Name = "Bazoka Kol",
                Level = 400,
                Description = "400 mil menzilli dörtlü döner namlulu taktisel bazoka."
            });
        }

        public void BuildRigthArm()
        {
            Character.AddAbility(new Block
            {
                Name = "İsveç Çakısı",
                Level = 100,
                Description = "Her türden tamirat işinde kullanılabilir İsveç çeliği ile güçlendirilmiş portatif çok amaçlı araç seti"
            });
        }

        public void BuildLeftLeg()
        {
            Character.AddAbility(new Block
            {
                Name = "Hızlandırıcı",
                Level = 400,
                Description = "2 Mach hıza ulaşmak için kullanılır. Sadece KSK-1009 tip kask varsa çalışır"
            });
        }

        public void BuildRightLeg()
        {
            Character.AddAbility(new Block
            {
                Name = "Teker",
                Level = 200,
                Description = "Otomatik seyrüsefer sistemi destekleyici tekerlek tabanlı bacak. Tek bacak üstünde sürüş yapabilir"
            });
        }
    }
}
