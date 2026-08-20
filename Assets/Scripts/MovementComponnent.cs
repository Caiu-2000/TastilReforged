using UnityEngine;

public class MovementComponnent : MonoBehaviour
{
    private Rigidbody _rb;
    [SerializeField] private float MaxSpeed = 2.0f;
    [SerializeField] private float Acceleration = 1.0f;
    [SerializeField] private float Deceleration = 1.0f;

    private Vector3 CurrentVelocity;
    private Vector3 DesiredDirection;


    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }
 
    private void FixedUpdate()
    {

        Vector3 targetVelocity = new Vector3();
        targetVelocity = (transform.forward * DesiredDirection.z + transform.right * DesiredDirection.x ) * MaxSpeed ;
  
  
        float rate;
        if (DesiredDirection.magnitude > 0)
        {
            rate = Acceleration;
        }
        else
        {
            rate = Deceleration * Time.fixedDeltaTime;
        }
      
        CurrentVelocity = Vector3.Lerp(
            CurrentVelocity,
            targetVelocity,
            rate 
        );

        
        _rb.linearVelocity = new Vector3(
            CurrentVelocity.x,
            _rb.linearVelocity.y,
            CurrentVelocity.z  
        );

    }

    public void SetDesiredDirection(Vector2 Direction)
    {
        DesiredDirection = new Vector3(Direction.x , DesiredDirection.y, Direction.y).normalized;
        
    }
    

}
