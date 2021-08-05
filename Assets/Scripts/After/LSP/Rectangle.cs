namespace After.LSP
{
    public class Rectangle : IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public int Area()
        {
            return Height * Width;
        }
    }
}