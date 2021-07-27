namespace Before.LSP
{
    public class Rectangle
    {
        public int _height;
        public int _width;

        public virtual void SetHeight(int height)
        {
            _height = height;
        }

        public virtual void SetWidth(int width)
        {
            _width = width;
        }

        public int Area()
        {
            return _height * _width;
        }
    }
}