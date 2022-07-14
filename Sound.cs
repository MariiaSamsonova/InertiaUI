using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace InertiaUI
{
    internal static class Sound
    {
        private static SoundPlayer sound = new SoundPlayer("sound.wav");

        private static bool _sound = true;

        public static void TurnOffSound()
        {
            _sound = false;

        }
        public static void TurnOnSound()
        {
            _sound = true;

        }
        public static bool SoundIsOn()
        {
            return _sound;
        }
        public static void Play()
        {
            sound.Play();
        }
    }
}
