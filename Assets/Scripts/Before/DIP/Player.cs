using Before.DIP.Attack;

namespace Before.DIP.Player
{
    public class Player
    {
        public void Attack()
        {
            var attack = new SlashAttack();
            attack.ApplyDamage();
        }
    }
}