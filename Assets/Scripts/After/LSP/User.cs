namespace After.LSP
{
    using UnityEngine;

    public class User : MonoBehaviour
    {
        void Start()
        {
            var rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 2;
            Debug.Assert(rectangle.Area() == 10);
        }
    }
}