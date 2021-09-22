namespace BuilderPattern.Models
{
    // Director sınıfı
    public interface IArmyDirector
    {
        void SetCharacterBuilder(ICharacterBuilder builder);
        void BuildSurgent();
        void BuildCaptain();
    }
}
