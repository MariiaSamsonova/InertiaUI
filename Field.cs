using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InertiaUI
{
    public partial class Field : UserControl
    {
        private int _width;
        private int _height;
        public Field()
        {
            InitializeComponent();
        }

        public void SetSize(int width, int height)
        {
            _width = width;
            _height = height;

            var square = new Square();
            Width = square.Width * width;
            Height = square.Height * height;

            Controls.Clear();
            for (var i = 0; i < height; i++)
            {
                for(var j = 0; j < width; j++)
                {
                    square = new Square();
                    if (i % 2 == j % 2)
                    {
                        square.AlterColor();
                    }
                    square.Left = square.Width * j;
                    square.Top = square.Height * i;
                    Controls.Add(square);
                }
            }
        }

        public void SetSymbol(int x, int y, char symbol)
        {
            string symbolString = "";
            symbolString += symbol;
            ((Square)Controls[y * _width + x]).SetSymbol(symbolString);
        }
    }
}
