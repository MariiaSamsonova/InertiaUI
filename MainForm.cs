using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InertiaUI
{
    public partial class MainForm : Form
    {
        static internal Scene _scene;
        static internal Player _player;
        static DateTime time;

        public MainForm()
        {
            InitializeComponent();
        }

        private void DrawField()
        {
            for (int y = 0; y < _scene.Height; y++)
            {
                for (int x = 0; x < _scene.Width; x++)
                {
                    if (x == _player.x && y == _player.y)
                    {
                        field.SetSymbol(x, y, '☺');

                    }
                    else
                        field.SetSymbol(x, y, _scene[x, y]);
                }
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            _player = new Player();
            gameResul.Text = "";
            _scene = new Scene();

            switch (comboBoxLevel.SelectedIndex)
            {

                case 0:
                    _scene.SetLevel(0);
                    break;
                case 1:
                    _scene.SetLevel(1);
                    break;
                case 2:
                    _scene.SetLevel(2);
                    break;
                default:
                    return;

            };

            field.SetSize(_scene.Width, _scene.Height);
            DrawField();
            time = DateTime.Now;
        }

        private void buttonUpLeft_Click(object sender, EventArgs e)
        {
            MakeMove(Direction.LeftUp, '☺');
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            MakeMove(Direction.Up, '☺');
        }

        private void buttonUpRight_Click(object sender, EventArgs e)
        {
            MakeMove(Direction.RightUp, '☺');
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            MakeMove(Direction.Left, '☺');
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            MakeMove(Direction.Right, '☺');
        }

        private void buttonDownLeft_Click(object sender, EventArgs e)
        {
            MakeMove(Direction.LeftDown, '☺');
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            MakeMove(Direction.Down, '☺');
        }

        private void buttonDownRight_Click(object sender, EventArgs e)
        {
            MakeMove(Direction.RightDown, '☺');
        }




        private void buttonSound_Click(object sender, EventArgs e)
        {
            switch (buttonSound.Text)
            {
                case "🔈":
                    {
                        buttonSound.Text = "🔇";
                        Sound.TurnOffSound();
                    }
                    break;
                case "🔇":
                    {
                        buttonSound.Text = "🔈";
                        Sound.TurnOnSound();
                    }
                    break;
            }

        }

        private void MakeMove(Direction direction, char name)
        {
            while (_scene.PrizeCount > 0 && _player.lives > 0)
            {
                Mechanics.GetNewPosition(direction, _player.x, _player.y, out var newPlayerX, out var newPlayerY);
                if (!Mechanics.CanMove(newPlayerX, newPlayerY))
                {
                    return;
                }

                DrawCell(_player.x, _player.y, _scene[_player.x, _player.y]);

                DrawCell(newPlayerX, newPlayerY, name);

                _player.x = newPlayerX;
                _player.y = newPlayerY;

                Action action = _scene.GetAction(_player.x, _player.y);

                switch (action)
                {
                    case Action.GameOver:
                        {
                            _player.lives--;
                            if (Sound.SoundIsOn())
                            {
                                Sound.Play();
                            }
                            if (_player.lives == 0)
                            {
                                GameOver();
                            }
                            break;
                        }
                    case Action.GetPrize:
                        _scene.GetPrize(_player.x, _player.y);
                        break;
                }

                if (_scene.PrizeCount == 0)
                {
                    Win();
                }

                if (_scene.MustStop(_player.x, _player.y))
                {
                    return;
                }

                if (_scene.PrizeCount == 0)
                {
                    return;
                }
                Application.DoEvents();
                Thread.Sleep(120);

            };
        }

        private void DrawCell(int x, int y, char symbol)
        {
            field.SetSymbol(x, y, symbol);
        }

        public void Win()
        {
            gameResul.Text = "Win\n" + "Lives left - " + _player.lives;
            string result = "\n" + DateTime.Now.Subtract(time) + "     " + _player.lives;
            if (_scene.Level == 1)
            {
                resultsLevel1.Text += result;
            }
            else if (_scene.Level == 2)
                resultsLevel2.Text += result;
        }

        public void GameOver()
        {
            gameResul.Text = "Game Over :(\n" + "Prizes left: " + _scene.PrizeCount;
        }
    }
}
