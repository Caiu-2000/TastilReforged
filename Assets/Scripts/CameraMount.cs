using UnityEngine;

[DefaultExecutionOrder(-4)]
public class CameraMount : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameManager.currentMount = this;
    }


}
