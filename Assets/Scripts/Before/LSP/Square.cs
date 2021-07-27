namespace Before.LSP
{
    public class Square : Rectangle
    {
        public void SetSide(int side)
        {
            this._width = side;
            this._width = side;
        }

        public override void SetHeight(int height)
        {
            this._height = height;
            this._width = height;
        }

        public override void SetWidth(int width)
        {
            this._height = width;
            this._width = width;
        }
    }
}