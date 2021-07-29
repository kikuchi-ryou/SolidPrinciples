namespace Before.LSP
{
    using UnityEngine;

    public class User : MonoBehaviour
    {
        void Start()
        {
            Rectangle rectangle = new Square();
            rectangle.Width = 5;
            rectangle.Height = 2;
            Debug.Assert(rectangle.Area() == 10);
        }
    }
}