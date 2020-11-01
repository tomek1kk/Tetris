using System.Collections.Generic;

namespace Tetris
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public (int id, Types type)[,] Fields { get; set; }

        public Board(int width, int height)
        {
            Width = width;
            Height = height;
            InitializeFields();
        }

        public bool CanPolyminoBePlaced(int x, int y, Point[] points)
        {
            foreach (Point point in points)
            {
                if (Fields[x + point.X, y + point.Y].type != Types.Empty)
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
                Fields[x + point.X, y + point.Y] = (0, polymino.Type);
            }
        }

        public void RemovePolymino(Point point)
        {
            // TODO: czyszczenie Fields
        }

        private void InitializeFields()
        {
            Fields = new (int, Types)[Height, Width];
            for (int i = 0; i < Fields.GetLength(0); i++)
            {
                for (int j = 0; j < Fields.GetLength(1); j++)
                {
                    Fields[i, j].type = Types.Empty;
                }
            }
        }
    }
}
