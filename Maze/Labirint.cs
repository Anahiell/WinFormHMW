using System;
using System.Windows.Forms;
using System.Drawing;

namespace Maze
{
    class Labirint
    {
        // позиция главного персонажа
        public int CharacterPositionX { get; set; }
        public int CharacterPositionY { get; set; }
        // позиция выхода
        public int ExitPositionX { get; set; }
        public int ExitPositionY { get; set; }

        public int createMedals { get; set; }//создано медалей
        public int countMedals { get; set; }//собрано медалей
        int height; // высота лабиринта (количество строк)
        int width; // ширина лабиринта (количество столбцов в каждой строке)

        public MazeObject[,] objects;

        public PictureBox[,] images;
        public double helthPoint;

        public static Random r = new Random();

        public Form parent;

        public Labirint(Form parent, int width, int height)
        {
            this.width = width;
            this.height = height;
            this.parent = parent;

            objects = new MazeObject[height, width];
            images = new PictureBox[height, width];

            CharacterPositionX = 0;
            CharacterPositionY = 4;

            ExitPositionX = height - 3;
            ExitPositionY = width - 1;

            createMedals = 0;
            countMedals = 0;

            helthPoint = 100;

            Generate();
        }
        public double RandDamage()
        {
            //в 1 случае из 2 разный урон
            if (r.Next(2) == 0)
            {

                return 100 * 0.25; ;
            }
            else

                return 100 * 0.2;
        }

        public void PointUp()
        {
            countMedals++;
        }
        void Generate()
        {

            for (int y = 2; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    MazeObject.MazeObjectType current = MazeObject.MazeObjectType.HALL;

                    // в 1 случае из 5 - ставим стену
                    if (r.Next(5) == 0)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }


                    // в 1 случае из 50 - размещаем врага
                    if (r.Next(50) == 0)
                    {
                        current = MazeObject.MazeObjectType.ENEMY;

                    }
                    //в 1 случае из 100 - хилка
                    if (r.Next(150) == 0)
                    {
                        current = MazeObject.MazeObjectType.HELTH;
                    }

                    // в 1 случае из 100 - кладём денежку
                    if (r.Next(100) == 0)
                    {

                        current = MazeObject.MazeObjectType.MEDAL;

                    }

                    // стены по периметру обязательны
                    if (y == 2 || x == 0 || y == height - 1 | x == width - 1)
                    {
                        current = MazeObject.MazeObjectType.WALL;
                    }

                    // наш персонажик
                    if (x == CharacterPositionX && y == CharacterPositionY)
                    {
                        current = MazeObject.MazeObjectType.CHAR;
                    }

                    // есть выход, и соседняя ячейка справа всегда свободна
                    if (x == CharacterPositionX + 1 && y == CharacterPositionY || x == width - 1 && y == height - 3)
                    {
                        current = MazeObject.MazeObjectType.HALL;
                    }
                    //выход из лабиринта есть возле выхода может появится стена, мы проверяем и устанавливаем выход
                    if (x == ExitPositionX && y == ExitPositionY)
                    {
                        current = MazeObject.MazeObjectType.EXIT;
                    }
                    if (x == ExitPositionX - 1 && y == ExitPositionY)
                    {
                        current = MazeObject.MazeObjectType.HALL;
                    }
                    objects[y, x] = new MazeObject(current);
                    images[y, x] = new PictureBox();
                    images[y, x].Location = new Point(x * objects[y, x].width, y * objects[y, x].height);
                    images[y, x].Parent = parent;
                    images[y, x].Width = objects[y, x].width;
                    images[y, x].Height = objects[y, x].height;
                    images[y, x].BackgroundImage = objects[y, x].texture;
                }
            }
            //подсчет медалей на поле
            for (int y = 3; y < height - 1; y++)
            {
                for (int x = 1; x < width - 1; x++)
                {
                    if (objects[y, x].type == MazeObject.MazeObjectType.MEDAL)
                    {
                        createMedals += 1;
                    }
                }
            }
        }
    }
}
