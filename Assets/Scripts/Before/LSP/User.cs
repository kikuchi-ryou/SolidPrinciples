namespace Before.LSP
{
    using UnityEngine;

    public class User : MonoBehaviour
    {
        void Start()
        {
            Rectangle rectangle = new Square();
            rectangle.SetWidth(5);
            rectangle.SetHeight(2);
            Debug.Assert(rectangle.Area() == 10);
        }
    }
}