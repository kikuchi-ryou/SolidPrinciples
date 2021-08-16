using UnityEngine;

namespace After.ISP
{
    public class Shadow : IAttack, IWalk
    {
        public void Attack()
        {
            Debug.Log("シャドウの攻撃");
        }

        public void Walk()
        {
            Debug.Log("シャドウが歩いて移動");
        }
    }
}