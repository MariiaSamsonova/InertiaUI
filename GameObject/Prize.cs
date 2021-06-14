using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaUI
{
    internal class Prize : GameObject
    {
        public override char Figure => '@';

        public override bool CanStepInto => true;

        public override Action Action => Action.GetPrize;

        public override bool MustStop => false;
    }
}
