using After.OCP;
using UnityEngine;

namespace OCP.Before
{
    public class Bullet : MonoBehaviour
    {
        void OnCollisionEnter(Collision collision)
        {
            var hit = collision.gameObject;
            var enemy = hit.GetComponent<IEnemy>();

            if (enemy == null)
                return;

            enemy.ApplyDamage();
        }
    }
}