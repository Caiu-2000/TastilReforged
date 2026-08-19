using UnityEngine;

public class MovementComponnent : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float MaxSpeed = 2.0f;
    [SerializeField] private float Acceleration = 1.0f;
    [SerializeField] private float Deceleration = 1.0f;

    private Vector2 CurrentVelocity;
    private Vector2 DesiredDirection;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
 
    private void FixedUpdate()
    {
        // Con esto saco el frente del personaje para que el frente sea donde mira
        Vector3 localTargetVelocity = (transform.forward * DesiredDirection.y + transform.right * DesiredDirection.x);
        
        Vector2 targetVelocity = DesiredDirection * MaxSpeed * localTargetVelocity;
        // Este codigo lo saque con ia para poder ahorrar el tipear.
        // Con esto se puede acelerar y desacelerar las entidades que se muevan
      
        float rate = (DesiredDirection.magnitude > 0) ? Acceleration : Deceleration;

  
        CurrentVelocity = Vector2.MoveTowards(
            CurrentVelocity,
            CurrentVelocity,
            rate * Time.fixedDeltaTime
        );

        
        _rb.linearVelocity = new Vector3(
            CurrentVelocity.x,
            _rb.linearVelocity.y,
            CurrentVelocity.y  
        );
        print("CurrentVelocity: " + CurrentVelocity + " targetVelocity : " + targetVelocity);
    }

    public void SetDirection(Vector2 Direction)
    {
        print("Direction: " + Direction);
        DesiredDirection = Direction.normalized;
    }
    

}
