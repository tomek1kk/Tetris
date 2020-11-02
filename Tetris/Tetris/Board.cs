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

        public Board(Board board)
        {
            Height = board.Height;
            Width = board.Width;
            Fields = new (int, Types)[Height, Width];
            for (int i = 0; i < board.Fields.GetLength(0); i++)
            {
                for (int j = 0; j < board.Fields.GetLength(1); j++)
                {
                    Fields[i, j] = board.Fields[i, j];
                }
            }
        }

        public bool CanPolyminoBePlacedInFields(int x, int y, Polymino polymino)
        {
            foreach (Point point in polymino.Points)
            {
                if (Fields[x + point.X, y + point.Y].type != Types.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CanPolyminoBePlacedInEmpty(int x, int y, Polymino polymino)
        {
            foreach (Point point in polymino.Points)
            {
                if (x + point.X >= Width || y + point.Y >= Height)
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

        public void RemovePolymino(int x, int y, Polymino polymino)
        {
            foreach (Point point in polymino.Points)
            {
                Fields[x + point.X, y + point.Y] = (0, Types.Empty);
            }
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
