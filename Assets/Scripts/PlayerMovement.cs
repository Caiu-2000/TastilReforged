
using UnityEngine;

public class PlayerMovement : MovementComponnent
{
    [SerializeField] private Transform CamMount;
    private float rotationY = 0f, _rotationX = 0f, rotationspeed = 25f;

    public void Start()
    {
        GameManager.inputManager.OnLookInput += HandleLookInput;
    }

    public void HandleLookInput(Vector2 LookInput)
    {
        rotationY += LookInput.x * rotationspeed * Time.deltaTime;
        transform.localRotation = Quaternion.Euler(0, rotationY, 0);

        _rotationX += LookInput.y * -rotationspeed * Time.deltaTime;
        _rotationX = Mathf.Clamp(_rotationX, -90f, 90f);

        CamMount.rotation = Quaternion.Euler(_rotationX, rotationY, 0f);
        print(CamMount.rotation);
    }
}
