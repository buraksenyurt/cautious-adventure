using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderPattern.Models
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
