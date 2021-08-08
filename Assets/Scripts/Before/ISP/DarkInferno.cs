using UnityEngine;

namespace Before.ISP
{
    public class DarkInferno : IEnemy
    {
        public void Attack()
        {
            Debug.Log("ダークインフェルノの攻撃");
        }

        public void Fly()
        {
            Debug.Log("ダークインフェルノが空を飛んで移動");
        }

        public void Walk()
        {
            throw new System.NotImplementedException();
        }
    }
}