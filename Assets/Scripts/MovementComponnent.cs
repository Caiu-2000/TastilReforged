
using System.Collections.Generic;
using UnityEngine;


public class MovementComponnent : MonoBehaviour , IObservable<movementData>
{
    private Rigidbody _rb;
    [SerializeField] private float MaxSpeed = 2.0f;
    [SerializeField] private float Acceleration = 1.0f;
    [SerializeField] private float Deceleration = 1.0f;

    private Vector3 CurrentVelocity;
    private Vector3 DesiredDirection;

    protected List<IObserver<movementData>> observers = new List<IObserver<movementData>>();

    private void Awake()
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

        movementData data = new movementData(CurrentVelocity);
        foreach (var item in observers)
        {
            item.Notify(data);

        }

    }

    public void SetDesiredDirection(Vector2 Direction)
    {
        DesiredDirection = new Vector3(Direction.x , DesiredDirection.y, Direction.y).normalized;
        
    }
    
    public void Suscribe(IObserver<movementData> observer)
    {
        observers.Add(observer);
    }

    public void UnSuscribe(IObserver<movementData> observer)
    {
        observers.Remove(observer);
    }
}

public struct movementData
{
    public Vector3 velocity;
    public movementData(Vector3 vel)
    {
        this.velocity = vel;
    }
}

