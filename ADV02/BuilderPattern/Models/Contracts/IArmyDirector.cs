namespace BuilderPattern.Models.Contracts
{
    // Director sınıfı
    public interface IArmyDirector
    {
        void SetCharacterBuilder(ICharacterBuilder builder);
        void BuildSurgent();
        void BuildCaptain();
    }
}
