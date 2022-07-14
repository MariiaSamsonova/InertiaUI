using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace InertiaUI
{
    class Scene
    {
        static private Dictionary<int, string> filesWhithLevels;

        static private int _level;

        private GameObject[,] _scene;
        public string[] _sceneLines;
        private GameObject cellUnderGost;

        public Scene()
        {
            string _defaultLevel = "Scenes\\Scene0.json";
            string Scene1 = "Scenes\\Scene1.json";
            string Scene2 = "Scenes\\Scene2.json";
            filesWhithLevels = new Dictionary<int, string>();
            filesWhithLevels.Add(0, _defaultLevel);
            filesWhithLevels.Add(1, Scene1);
            filesWhithLevels.Add(2, Scene2);


        }

        internal int GetHeight()
        {
            throw new NotImplementedException();
        }

        internal void SetLevel(int level)
        {
            _level = level;
            if (!File.Exists(filesWhithLevels[level]))
            {
                throw new FileNotFoundException("File dose not exist");
            }

            var linesText = File.ReadAllText(filesWhithLevels[level]);

            _sceneLines = JsonSerializer.Deserialize<string[]>(linesText);
            var width = _sceneLines[0].Length;
            _scene = new GameObject[_sceneLines.Length, width];

            DefineStartPosition();

            for (int y = 0; y < _sceneLines.Length; y++)
            {
                if (_sceneLines[y].Length != width) throw new ArgumentException("All strings must have the same length");
                for (int x = 0; x < width; x++)
                {
                    _scene[y, x] = GameObject.Create(_sceneLines[y][x]);
                }
            }

            CountPrizes();
            
        }

        private void CountPrizes()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    if (_scene[y, x] is Prize)
                    {
                        PrizeCount++;
                    }
                }
            }
        }


        internal int GetLine(int y)
        {
            throw new NotImplementedException();
        }

        internal void DefineStartPosition()
        {
            for (int y = 0; y < Height; y++)
            {
                var x = _sceneLines[y].IndexOf("I");
                if (x >= 0)
                {
                    MainForm._player.x = x;
                    MainForm._player.y = y;
                    _sceneLines[y] = _sceneLines[y].Replace('I', ' ');
                    break;
                }
            }
        }

        internal bool MustStop(int x, int y)
        {
            return _scene[y, x].MustStop;
        }

        internal void GetPrize(int x, int y)
        {
            PrizeCount--;
            _scene[y, x] = new EmptyCell();
        }

        //Nothing, GetPrize, GameOver
        internal Action GetAction(int x, int y)
        {
            return _scene[y, x].Action;
        }

        internal bool CanStepInto(int x, int y)
        {
            return _scene[y, x].CanStepInto;
        }


        public int Width => _scene.GetLength(1);

        public int Height => _scene.GetLength(0);
        public int PrizeCount { get; internal set; }

        public int Level => _level;

        public char this[int x, int y] => _scene[y, x].Figure;


    }
}

