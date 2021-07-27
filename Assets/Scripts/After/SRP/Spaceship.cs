using UnityEngine;

[RequireComponent(typeof(Movable))]
public class Spaceships : MonoBehaviour
{
    // 移動用コンポーネント
    [SerializeField] private Movable movable;

    void Start()
    {
        // ローカル座標のY軸のマイナス方向に移動する
        movable.Move(transform.up * -1);
    }
}