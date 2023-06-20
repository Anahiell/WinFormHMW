using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Maze
{
    public partial class Form1 : Form
    {
        // размеры лабиринта в ячейках 16х16 пикселей
        int columns = 20;
        int rows = 22;

        int pictureSize = 16; // ширина и высота одной ячейки

        Labirint l; // ссылка на логику всего происходящего в лабиринте

        int steps = 0;//кол-во шагов

        int timeSec;
        int timeMin;

        float tick_tack;


        DateTime timeL;
        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
        }

        public void Options()
        {
            Text = "Maze";
            BackColor = Color.FromArgb(255, 92, 118, 137);

            // размеры клиентской области формы (того участка, на котором размещаются ЭУ)
            ClientSize = new Size(columns * pictureSize, rows * pictureSize);

            StartPosition = FormStartPosition.CenterScreen;
        }

        public void StartGame()
        {
            l = new Labirint(this, columns, rows);

            Helth_point_bar.Value = 100;
            toolStripStatusLabel2.Text = $"{l.helthPoint} HP";//состояние хп

            scoreStLabl.Text = $"{l.createMedals}/{l.countMedals}";//медали

            toolsStep.Text = $"Steps:{steps}";//шаги

            timeSec = 0;
            timeMin = 0;
            timer1 = new Timer();
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            timer1.Start();


            timeLook.Text = $"{timeMin}:{timeSec}";
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)//добавлено управление WASD
            {
                // проверка на то, свободна ли ячейка справа
                if (l.objects[l.CharacterPositionY, l.CharacterPositionX + 1].type ==
                    MazeObject.MazeObjectType.HALL) // проверяем ячейку правее на 1 позицию, является ли она коридором
                {
                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                }
                //проверка на медаль
                else if ((l.objects[l.CharacterPositionY, l.CharacterPositionX + 1].type ==
                    MazeObject.MazeObjectType.MEDAL) && (l.countMedals != l.createMedals)) // проверяем ячейку правее на 1 позицию, является ли она Medal
                {
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);

                    steps++;
                    l.PointUp();
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                }
                // enemy
                else if ((l.objects[l.CharacterPositionY, l.CharacterPositionX + 1].type ==
                    MazeObject.MazeObjectType.ENEMY))
                {

                    steps++;
                    if ((l.helthPoint - l.RandDamage()) <= 0)
                    {
                        MessageBox.Show("Потрачено", "You LOSE!!!", MessageBoxButtons.OK);
                    }
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    if ((l.helthPoint - l.RandDamage()) <= 0)
                        return;
                    l.helthPoint -= l.RandDamage();//полученый урон отнимается от хп
                }
                //healing
                else if ((l.objects[l.CharacterPositionY, l.CharacterPositionX + 1].type ==
                    MazeObject.MazeObjectType.HELTH) && l.helthPoint != 100)
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.helthPoint += 100 * 0.05;//полученый урон отнимается от хп
                }
                //проверка на выход
                else if ((l.objects[l.CharacterPositionY, l.CharacterPositionX + 1].type ==
                    MazeObject.MazeObjectType.EXIT))
                {
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);

                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                }
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (l.objects[l.CharacterPositionY, l.CharacterPositionX - 1].type ==
                   MazeObject.MazeObjectType.HALL) // проверяем ячейку левее на 1 позицию, является ли она коридором
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX--;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                }
                //медаль?
                else if ((l.objects[l.CharacterPositionY, l.CharacterPositionX - 1].type ==
                    MazeObject.MazeObjectType.MEDAL) && (l.countMedals != l.createMedals)) // проверяем ячейку правее на 1 позицию, является ли она Medal
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);

                    l.PointUp();

                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX--;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                }
                //enemy
                else if ((l.objects[l.CharacterPositionY, l.CharacterPositionX - 1].type ==
                    MazeObject.MazeObjectType.ENEMY))
                {

                    steps++;
                    if ((l.helthPoint - l.RandDamage()) <= 0)
                    {
                        MessageBox.Show("Потрачено", "You LOSE!!!", MessageBoxButtons.OK);
                    }
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX--;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                    if ((l.helthPoint - l.RandDamage()) <= 0)
                        return;
                    l.helthPoint -= l.RandDamage();//полученый урон отнимается от хп
                }
                //healing
                else if ((l.objects[l.CharacterPositionY, l.CharacterPositionX - 1].type ==
                   MazeObject.MazeObjectType.HELTH) && l.helthPoint < 100)
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionX--;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.helthPoint += 100 * 0.05;//полученый урон отнимается от хп
                }
            }
            else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {

                if (l.objects[l.CharacterPositionY + 1, l.CharacterPositionX].type ==
                                   MazeObject.MazeObjectType.HALL) // проверяем ячейку снизу на 1 позицию, является ли она коридором
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionY++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                }
                //медаль?
                else if ((l.objects[l.CharacterPositionY + 1, l.CharacterPositionX].type ==
                    MazeObject.MazeObjectType.MEDAL) && (l.countMedals != l.createMedals)) // проверяем ячейку правее на 1 позицию, является ли она Medal
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);

                    l.PointUp();

                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionY++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                }
                // enemy
                else if ((l.objects[l.CharacterPositionY + 1, l.CharacterPositionX].type ==
                    MazeObject.MazeObjectType.ENEMY))
                {

                    steps++;
                    if ((l.helthPoint - l.RandDamage()) <= 0)
                    {
                        MessageBox.Show("Потрачено", "You LOSE!!!", MessageBoxButtons.OK);
                    }
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionY++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    if ((l.helthPoint - l.RandDamage()) <= 0)
                        return;
                    l.helthPoint -= l.RandDamage();//полученый урон отнимается от хп

                }
                //healing
                else if ((l.objects[l.CharacterPositionY + 1, l.CharacterPositionX].type ==
                   MazeObject.MazeObjectType.HELTH) && l.helthPoint < 100)
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionY++;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.helthPoint += 100 * 0.05;//полученый урон отнимается от хп
                }
            }
            else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (l.objects[l.CharacterPositionY - 1, l.CharacterPositionX].type ==
                                   MazeObject.MazeObjectType.HALL) // проверяем ячейку вверху на 1 позицию, является ли она коридором
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionY--;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                }
                //медаль?
                else if ((l.objects[l.CharacterPositionY - 1, l.CharacterPositionX].type ==
                    MazeObject.MazeObjectType.MEDAL) && (l.countMedals != l.createMedals)) // проверяем ячейку правее на 1 позицию, является ли она Medal
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);

                    l.PointUp();

                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionY--;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;
                }
                // enemy
                else if ((l.objects[l.CharacterPositionY - 1, l.CharacterPositionX].type ==
                    MazeObject.MazeObjectType.ENEMY))
                {

                    steps++;
                    if ((l.helthPoint - l.RandDamage()) <= 0)
                    {
                        MessageBox.Show("Потрачено", "You LOSE!!!", MessageBoxButtons.OK);
                    }
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionY--;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    if ((l.helthPoint - l.RandDamage()) <= 0)
                        return;
                    l.helthPoint -= l.RandDamage();//полученый урон отнимается от хп

                }
                //healing
                else if ((l.objects[l.CharacterPositionY - 1, l.CharacterPositionX].type ==
                   MazeObject.MazeObjectType.HELTH) && (l.helthPoint < 100))
                {

                    steps++;
                    l.objects[l.CharacterPositionY, l.CharacterPositionX] = new MazeObject(MazeObject.MazeObjectType.HALL);
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.CharacterPositionY--;

                    l.objects[l.CharacterPositionY, l.CharacterPositionX].texture = MazeObject.images[4]; // character
                    l.images[l.CharacterPositionY, l.CharacterPositionX].BackgroundImage = l.objects[l.CharacterPositionY, l.CharacterPositionX].texture;

                    l.helthPoint += 100 * 0.05;//полученый урон отнимается от хп
                }
            }
            if ((l.CharacterPositionX == l.ExitPositionX && l.ExitPositionY == l.ExitPositionY) || (l.createMedals == l.countMedals))
            {
                MessageBox.Show("Успех", "You WIN!!!", MessageBoxButtons.OK);
            }
            //меньше 45 хп цвет становится красным
            if (Math.Round(l.helthPoint, 1) < 45)
            {
                toolStripStatusLabel2.BackColor = Color.OrangeRed;
            }
            else
                toolStripStatusLabel2.BackColor = Color.Lime;
            var t = Math.Round(l.helthPoint, 1);
            toolStripStatusLabel2.Text = $"{t} HP";
            Helth_point_bar.Value = (int)l.helthPoint;
            scoreStLabl.Text = $"{l.createMedals}/{l.countMedals}";
            toolsStep.Text = $"Steps:{steps}";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSec++;
            timeMin += timeSec / 60;
            if (timeSec > 60) timeSec = 0;
            timeLook.Text = $"{timeMin}:{timeSec}";

            //чем дольше тикает тем краснее становитсяъ
            Random rnd = new Random();
            int R = 0;
            int G = 255;
            int B = 0;
            if (tick_tack >= 1f && tick_tack < 255)
            {
                R += (int)tick_tack;
                G -= (int)tick_tack;


                timeLook.BackColor = Color.FromArgb(R, G, B);
            }
            tick_tack += 10f;
        }
    }
}