namespace BuilderPattern.Models
{
    // Builder sözleşmesi
    public interface ICharacterBuilder
    {
        void BuildBody();
        void BuildLeftArm();
        void BuildRigthArm();
        void BuildLeftLeg();
        void BuildRightLeg();
        Character GetCharacter();
    }
}
