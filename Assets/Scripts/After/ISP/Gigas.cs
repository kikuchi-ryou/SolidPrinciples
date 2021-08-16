using UnityEngine;

namespace After.ISP
{
    public class Gigas : IAttack, IFly, IWalk
    {
        public void Attack()
        {
            Debug.Log("ギガースの攻撃");
        }

        public void Fly()
        {
            Debug.Log("ギガースが空を飛ぶ");
        }

        public void Walk()
        {
            Debug.Log("ギガースが歩く");
        }
    }
}