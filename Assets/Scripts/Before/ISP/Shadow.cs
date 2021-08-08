using UnityEngine;

namespace Before.ISP
{
    public class Shadow : IEnemy
    {
        public void Attack()
        {
            Debug.Log("シャドウの攻撃");
        }

        public void Fly()
        {
            throw new System.NotImplementedException();
        }

        public void Walk()
        {
            Debug.Log("シャドウが歩いて移動");
        }
    }
}