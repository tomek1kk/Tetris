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

        public bool CanPolyminoBePlacedInFields(int y, int x, Polymino polymino)
        {
            foreach (Point point in polymino.Points)
            {
                if (!IsInsideBoardAndEmpty(y, x, point))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsInsideBoardAndEmpty(int y, int x, Point point) =>
            y + point.Y < Fields.GetLength(0)
            && x + point.X < Fields.GetLength(1)
            && Fields[y + point.Y, x + point.X].type == Types.Empty;

        public bool CanPolyminoBePlacedInEmpty(int y, int x, Polymino polymino)
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

        public void PlacePolymino(int y, int x, Polymino polymino)
        {
            foreach (Point point in polymino.Points)
            {
                Fields[y + point.Y, x + point.X] = (0, polymino.Type);
            }
        }

        public void RemovePolymino(int y, int x, Polymino polymino)
        {
            foreach (Point point in polymino.Points)
            {
                Fields[y + point.Y, x + point.X] = (0, Types.Empty);
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

        public int RatePosition(int y, int x, Polymino polymino)
        {
            int score = 0;
            foreach (Point point in polymino.Points)
            {
                var cur_x = x + point.X;
                var cur_y = y + point.Y;

                //score += cur_x >= Width - 1 || Fields[cur_x + 1, cur_y].type != Types.Empty ? 1 : 0;
                //score += cur_x <= 0 || Fields[cur_x - 1, cur_y].type != Types.Empty ? 1 : 0;
                //score += cur_y >= Height - 1 || Fields[cur_x, cur_y + 1].type != Types.Empty ? 1 : 0;
                //score += cur_y <= 0 || Fields[cur_x, cur_y - 1].type != Types.Empty ? 1 : 0;
                score += cur_x >= Width - 1 || Fields[cur_y, cur_x + 1].type != Types.Empty ? 1 : 0;
                score += cur_x <= 0 || Fields[cur_y, cur_x - 1].type != Types.Empty ? 1 : 0;
                score += cur_y >= Height - 1 || Fields[cur_y + 1, cur_x].type != Types.Empty ? 1 : 0;
                score += cur_y <= 0 || Fields[cur_y - 1, cur_x].type != Types.Empty ? 1 : 0;
            }
            return score;

        }


        public List<Point> GetFreePoints()
        {
            List<Point> points = new List<Point>();
            for (int i = 0; i < Fields.GetLength(0); i++)
            {
                for (int j = 0; j < Fields.GetLength(1); j++)
                {
                    if (Fields[i, j].type == Types.Empty)
                        points.Add(new Point(i, j));
                }
            }
            return points;
        }
    }
}
