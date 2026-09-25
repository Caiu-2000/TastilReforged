using UnityEngine;

public class CameraTilter : MonoBehaviour
{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GameManager.player.GetComponent<Rigidbody>();
    }
    //        Vector3 TiltDirection = (transform.position - hittdata.AttackFrom).normalized;

    // Update is called once per frame
    void Update()
    {
        
    }
}
