using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InertiaUI
{
    class Scene
    {
        private GameObject[,] _scene;

        private GameObject cellUnderGost;

        //конструктор
        public Scene(string[] scene)
        {
            var width = scene[0].Length;

            _scene = new GameObject[scene.Length, width];


            //генерация поля
            for (int y = 0; y < scene.Length; y++)
            {
                if (scene[y].Length != width) throw new ArgumentException("All strings must have the same length");
                for (int x = 0; x < width; x++)
                {
                    _scene[y, x] = GameObject.Create(scene[y][x]);
                }
            }


            //подсчет призов
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

        }//конструктор


        //должен ли игрк остановится на данной клетке
        internal bool MustStop(int x, int y)
        {
            return _scene[y, x].MustStop;
        }

        //собираем приз
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

        //может ли наступить на данную клетку
        internal bool CanStepInto(int x, int y)
        {
            if (_scene[y, x] is Ghost)
                return cellUnderGost.CanStepInto;
            return _scene[y, x].CanStepInto;
        }


        internal void GhostStep(int x, int y)
        {
            cellUnderGost = _scene[y, x];
            _scene[y, x] = new Ghost();
        }

        internal void GhostGone(int x, int y)
        {
            _scene[y, x] = cellUnderGost;
        }

        public int Width => _scene.GetLength(1);

        public int Height => _scene.GetLength(0);
        public int PrizeCount { get; internal set; }


        //индексатор(получаем символ отображающий клетку поля)
        public char this[int x, int y] => _scene[y, x].Figure;


    }
}

