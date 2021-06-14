using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaUI
{
    internal class Wall : GameObject
    {
        public override char Figure => '#';

        public override bool CanStepInto => false;

        public override Action Action => throw new InvalidOperationException("Must not be called");

        public override bool MustStop => throw new InvalidOperationException("Must not be called");
    }
}
