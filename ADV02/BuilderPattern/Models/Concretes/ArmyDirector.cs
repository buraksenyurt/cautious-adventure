using BuilderPattern.Models.Contracts;

namespace BuilderPattern.Models.Concretes
{
    public class ArmyDirector
        : IArmyDirector
    {
        private ICharacterBuilder _builder;
        public void BuildCaptain()
        {
            _builder.BuildBody();
            _builder.BuildLeftArm();
            _builder.BuildRigthArm();
            _builder.BuildRightLeg();
            _builder.BuildLeftLeg();            
        }

        public void BuildSurgent()
        {
            _builder.BuildBody();
            _builder.BuildRigthArm();
            _builder.BuildLeftLeg();
        }

        public void SetCharacterBuilder(ICharacterBuilder builder)
        {
            _builder = builder;
        }
    }
}
