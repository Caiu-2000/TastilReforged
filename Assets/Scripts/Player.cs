using UnityEngine;

[DefaultExecutionOrder(-3)]
public class Player : Entity
{
    [SerializeField] protected MovementComponnent MoveComp = new MovementComponnent();
    void Start()
    {
        GameManager.player = this;
        GameManager.inputManager.OnMoveInput += MoveComp.SetDirection;
    }


}
