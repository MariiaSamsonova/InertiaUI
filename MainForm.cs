using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InertiaUI
{
    public partial class MainForm : Form
    {
        static private SoundPlayer sound = new SoundPlayer("sound.wav");

        static private string _fileName = "Scenes\\Scene1.json";
        static private string _fileName2 = "Scenes\\Scene3.json";

        static private string[] _defaultLevel = {
            "I         ",
            "    @  @% ",
            "@  *    # ",
            "  %@@     ",
            " *  %%    ",
            "     @%@  ",
            "       * #",
            "      @   ",
            " * #  %*  ",
            " %#@  @  #"};

        static private string[] _sceneLines;
        static private Scene _scene;

        static private int _playerX = 0;
        static private int _playerY = 0;
        static private int _ghostX = 0;
        static private int _ghostY = 0;

        static private int _lives = 3;
        static private int _level;

        static bool _sound = true;
        static DateTime time;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Play()
        {
            PlayerStartPosition();
            _scene = new Scene(_sceneLines);
            int height = _scene.Height;
            int width = _scene.Width;

            field.SetSize(width, height);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if(x == _playerX && y == _playerY)
                    {
                        field.SetSymbol(x, y, '☺');

                    }
                    else
                        field.SetSymbol(x, y, _scene[x, y]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _playerX = 0;
            _playerY = 0;
            label2.Text = "";
            _lives = 3;
            switch (comboBoxLevel.SelectedIndex)
            {

                case 0:
                    _level = 1;
                    if (!File.Exists(_fileName))
                    {
                        throw new FileNotFoundException("File dose not exist");
                    }

                    var linesText = File.ReadAllText(_fileName);

                    _sceneLines = JsonSerializer.Deserialize<string[]>(linesText);
                    break;
                case 1:
                    _level = 2;
                    _sceneLines = _defaultLevel;
                    break;
                case 2:
                    _level = 3;
                    if (!File.Exists(_fileName2))
                    {
                        throw new FileNotFoundException("File dose not exist");
                    }

                    var linesText2 = File.ReadAllText(_fileName2);

                    _sceneLines = JsonSerializer.Deserialize<string[]>(linesText2);
                    break;
                default:
                    return;

            }

            Play();
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

        private static void PlayerStartPosition()
        {
            for (int y = 0; y < _sceneLines.Length; y++)
            {
                var x = _sceneLines[y].IndexOf("I");
                if (x >= 0)
                {
                    _playerX = x;
                    _playerY = y;
                    _sceneLines[y] = _sceneLines[y].Replace('I', ' ');
                    break;
                }
            }
        }

        private void MakeMove(Direction direction, char name)
        {
            while(_scene.PrizeCount > 0 && _lives > 0)
            {
                GetNewPosition(direction, _playerX, _playerY, out var newPlayerX, out var newPlayerY);
                if (newPlayerX < 0 || newPlayerY < 0 || newPlayerX >= _scene.Width || newPlayerY >= _scene.Height)
                {
                    return;//ничего не делаем если игрок пытается выйти за границу поля
                }

                if (!_scene.CanStepInto(newPlayerX, newPlayerY))
                {
                    return;//ничего не делаем если игрок не может наступить на клетку
                }

                DrawCell(_playerX, _playerY, _scene[_playerX, _playerY]);

                DrawCell(newPlayerX, newPlayerY, name);

                _playerX = newPlayerX;
                _playerY = newPlayerY;

                Action action = _scene.GetAction(_playerX, _playerY);

                switch (action)
                {
                    case Action.GameOver:
                        {
                            _lives--;
                            if (_sound == true)
                            {
                                    sound.Play();
                            }
                            if (_lives == 0)
                            {
                                GameOver();//проиграш
                            }
                            break;
                        }
                    case Action.GetPrize:
                        _scene.GetPrize(_playerX, _playerY);
                        break;
                }

                if (_scene.PrizeCount == 0)
                {
                    Win();
                }

                if (_scene.MustStop(_playerX, _playerY))
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

        private void Win()
        {
            label2.Text = "Win\n" + "Осталось жизней - " + _lives;
            string result = "\n" + DateTime.Now.Subtract(time) + "     " + _lives;
            if (_level == 1)
            {
                label4.Text += result;
            }
            else if(_level == 2)
                label5.Text += result;
        }

        private void GameOver()
        {
                label2.Text = "Game Over :(\n" + "Осталось несобраных призов - " + _scene.PrizeCount;
        }

        private static void GetNewPosition(Direction direction, int _playerX, int _playerY, out int newPlayerX, out int newPlayerY)
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

        private void buttonSound_Click(object sender, EventArgs e)
        {
            switch (buttonSound.Text)
            {
                case "🔈":
                    {
                        buttonSound.Text = "🔇";
                        _sound = false;
                    }
                    break;
                case "🔇":
                    {
                        buttonSound.Text = "🔈";
                        _sound = true;
                    }
                    break;
            }

        }
        private void DrawCell(int x, int y, char symbol)
        {
            field.SetSymbol(x, y, symbol);
        }
    }
}
