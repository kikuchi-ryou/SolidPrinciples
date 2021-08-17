using After.DIP.Attack;
using After.DIP.Player;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        var attack = new SlashAttack();
        var player = new Player(attack);
        player.Attack();
    }
}