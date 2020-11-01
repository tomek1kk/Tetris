using System.Collections.Generic;

namespace Tetris
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Types[,] Fields { get; set; }
        public Dictionary<Point, Polymino> Polyminos { get; set; }

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
            InitializeFields();
        }

        public bool CanPentominoBePlaced(int x, int y, Point[] points)
        {
            foreach (Point point in points)
            {
                if (Fields[x + point.X, y + point.Y] != Types.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        public void PlacePolymino(int x, int y, Polymino polymino)
        {
            foreach (Point point in polymino.Points)
            {
                Fields[x + point.X, y + point.Y] = polymino.Type;
                Polyminos.Add(new Point(x, y), polymino);
            }
        }

        public void RemovePolymino(Point point)
        {
            Polyminos.Remove(point);
            // TODO: czyszczenie Fields
        }

        private void InitializeFields()
        {
            Polyminos = new Dictionary<Point, Polymino>();
            Fields = new Types[Height, Width];
            for (int i = 0; i < Fields.GetLength(0); i++)
            {
                for (int j = 0; j < Fields.GetLength(1); j++)
                {
                    Fields[i, j] = Types.Empty;
                }
            }
        }
    }
}
