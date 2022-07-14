using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaUI
{
    internal class Mechanics
    {
        public static void GetNewPosition(Direction direction, int _playerX, int _playerY, out int newPlayerX, out int newPlayerY)
        {
            newPlayerX = _playerX;
            newPlayerY = _playerY;

            if (direction == Direction.Up || direction == Direction.LeftUp || direction == Direction.RightUp)
            {
                --newPlayerY;
            }
            if (direction == Direction.Down || direction == Direction.LeftDown || direction == Direction.RightDown)
            {
                ++newPlayerY;
            }
            if (direction == Direction.Left || direction == Direction.LeftDown || direction == Direction.LeftUp)
            {
                --newPlayerX;
            }
            if (direction == Direction.Right || direction == Direction.RightDown || direction == Direction.RightUp)
            {
                ++newPlayerX;
            }
        }

        internal static bool CanMove(int newPlayerX, int newPlayerY)
        {

            if (newPlayerX < 0 || newPlayerY < 0 || newPlayerX >= MainForm._scene.Width || newPlayerY >= MainForm._scene.Height)
            {
                return false;
            }

            if (!MainForm._scene.CanStepInto(newPlayerX, newPlayerY))
            {
                return false;
            }
            return true;
        }
    }

}
