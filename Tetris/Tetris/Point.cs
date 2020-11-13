namespace Tetris
{
    public struct Point
    {
        public int Y { get; set; }
        public int X { get; set; }
        public Point(int y, int x)
        {
            X = x;
            Y = y;
        }
    }
}
