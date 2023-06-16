using System.Drawing;

namespace Maze
{
    class MazeObject
    {
        public enum MazeObjectType { HALL, WALL, MEDAL, ENEMY, CHAR, HELTH, EXIT, EMPTY, STAR };

        public static Bitmap[] images = { new Bitmap(Properties.Resources.hall),//0
            new Bitmap(Properties.Resources.wall), // wall//1
            new Bitmap(Properties.Resources.medal), // medal//2
            new Bitmap(Properties.Resources.enemy), // enemy//3
            new Bitmap(Properties.Resources.player),// player//4
            new Bitmap(Properties.Resources.hp),// hp//5
            new Bitmap(Properties.Resources.exit),//exit//6
            new Bitmap(Properties.Resources.emptyStar),//empty star//7
            new Bitmap(Properties.Resources.star)}; //star//8

        public MazeObjectType type;

        public int width;
        public int height;
        public Image texture;

        public MazeObject(MazeObjectType type)
        {
            this.type = type;
            width = 16;
            height = 16;
            texture = images[(int)type];
        }
    }
}
