using BuilderPattern.Models.Product;

namespace BuilderPattern.Models.Contracts
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
