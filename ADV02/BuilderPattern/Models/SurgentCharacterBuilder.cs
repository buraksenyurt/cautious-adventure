namespace BuilderPattern.Models
{
    // Builder sözleşmesini uygulayan asıl sınıf(Concrete Builder)
    public class SurgentCharacterBuilder
        : ICharacterBuilder
    {
        public Character Character { get; set; } = new Character();
        public SurgentCharacterBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            Character = new Character() { Nickname = "Piyade", Location = "Dünya" };
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
                Name = "Çelik Zırh",
                Level = 400,
                Description = "Işın geçirmez çelik zırh. 4D seviyedeki ışınlara karşı koruma sağlar."
            });
        }
        public void BuildLeftArm()
        {
            Character.AddAbility(new Block
            {
                Name = "Güçlendirilmiş Kol",
                Level = 200,
                Description = "30 Bar basınç uygulayabilir."
            });
        }

        public void BuildRigthArm()
        {
            Character.AddAbility(new Block
            {
                Name = "Kanca",
                Level = 100,
                Description = "Kaptan Hook stilinde aksesuar görünümlü kanca."
            });
        }

        public void BuildLeftLeg()
        {
            Character.AddAbility(new Block
            {
                Name = "Zıplatıcı",
                Level = 200,
                Description = "Tek seferde yerçekimsiz 150 metre fırlatma sağlar"
            });
        }

        public void BuildRightLeg()
        {
            Character.AddAbility(new Block
            {
                Name = "Süpürücü",
                Level = 300,
                Description = "Aynı anda 360 derece toz emiş gücüne sahip süpürge bacak"
            });
        }
    }
}
