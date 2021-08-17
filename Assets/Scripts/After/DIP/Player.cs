namespace After.DIP.Player
{
    public class Player
    {
        IAttack _attack;
        public Player(IAttack attack)
        {
            _attack = attack;
        }

        public void Attack()
        {
            _attack.ApplyDamage();
        }
    }
}