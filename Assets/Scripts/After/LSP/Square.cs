namespace After.LSP
{
    public class Square : IShape
    {
        public int SideLength { get; set; }

        public int Area()
        {
            return SideLength * SideLength;
        }
    }
}