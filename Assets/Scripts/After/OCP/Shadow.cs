using UnityEngine;

namespace After.OCP
{
    public class Shadow : MonoBehaviour, IEnemy
    {
        public void ApplyDamage()
        {
            Debug.Log("Shadow");
        }
    }
}