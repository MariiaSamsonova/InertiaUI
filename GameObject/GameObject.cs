using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaUI
{
    abstract class GameObject
    {
        public abstract char Figure { get; }

        public abstract bool CanStepInto { get; }
        public abstract Action Action { get; }
        public abstract bool MustStop { get; }

        internal static GameObject Create(char figure)
        {
            switch (figure)
            {
                case ' ':
                    return new EmptyCell();
                case '#':
                    return new Wall();
                case '%':
                    return new Trap();
                case '*':
                    return new Stop();
                case '@':
                    return new Prize();
            }

            throw new ArgumentOutOfRangeException(nameof(figure));
        }
    }
}
