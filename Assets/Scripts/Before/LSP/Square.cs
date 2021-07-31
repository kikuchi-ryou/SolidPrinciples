namespace Before.LSP
{
    public class Square : Rectangle
    {
        int _height;
        int _width;
        public override int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                _width = value;
            }
        }
        public override int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
                _height = value;
            }
        }
    }
}