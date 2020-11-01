namespace Tetris
{
    public class Board
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Types[,] Fields { get; set; }

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
                if(Fields[x + point.X, y + point.Y] != Types.Empty)
                {
                    return false;
                }
            }
            return true;
        }

        public void PlacePentomino(int x, int y, Point[] points, Types type)
        {
            foreach (Point point in points)
            {
                Fields[x + point.X, y + point.Y] = type;

            }
        }

        private void InitializeFields()
        {
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
