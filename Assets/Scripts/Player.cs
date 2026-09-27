using UnityEngine;

[DefaultExecutionOrder(-3)]

public class Player : Entity
{
    [SerializeField] protected MovementComponnent MoveComp;
    [SerializeField] protected InventoryComponnent Inventory;

    [SerializeField] protected CameraBrain camBrain;
    void Start()
    {
        MoveComp = GetComponent<MovementComponnent>();
        GameManager.player = this;
        GameManager.inputManager.OnMoveInput += MoveComp.SetDesiredDirection;
        MoveComp.Suscribe(camBrain);
    }

    private void OnDisable()
    {
        MoveComp.UnSuscribe(camBrain);
    }
}
