using UnityEngine;

[DefaultExecutionOrder(-3)]

public class Player : Entity
{
    [SerializeField] protected MovementComponnent MoveComp;
    void Start()
    {
        MoveComp = GetComponent<MovementComponnent>();
        GameManager.player = this;
        GameManager.inputManager.OnMoveInput += MoveComp.SetDesiredDirection;
    }


}
