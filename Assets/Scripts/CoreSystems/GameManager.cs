
using System.Collections;
using UnityEngine;


[DefaultExecutionOrder(-10)]
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static InputManager inputManager;
    public static CameraMount currentMount;
    public static Player player;
    public static UiManager Ui;
    void Start()
    {
        if (instance == null) instance = this;
        else { Destroy(this.gameObject); }

        DontDestroyOnLoad(gameObject);
    }

    public void UniversalTimer(float time , ITimable Caller)
    {
        StartCoroutine(BasicTimer(time , Caller));
    }
    private IEnumerator BasicTimer(float time , ITimable Caller)
    {
        yield return new WaitForSeconds(time);
        Caller.TimeStopped();
    }
}
