
using System.Collections;
using UnityEngine;


[DefaultExecutionOrder(-10)]
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static InputManager inputManager;
    public static CameraMount currentMount;
    public static Player player;
    void Start()
    {
        if (instance == null) instance = this;
        else { Destroy(this.gameObject); }

        DontDestroyOnLoad(gameObject);
    }

    public IEnumerator UniversalTimer(float time , ITimable Caller)
    {
        yield return new WaitForSeconds(time);
        Caller.TimeStopped();
    }
}
