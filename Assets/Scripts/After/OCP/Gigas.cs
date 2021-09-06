using UnityEngine;

namespace After.OCP
{
    public class Gigas : MonoBehaviour, IEnemy
    {
        public void ApplyDamage()
        {
            Debug.Log("Gigas");
        }
    }
}