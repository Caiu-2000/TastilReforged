
using System.Collections;
using UnityEngine;


[DefaultExecutionOrder(-10)]
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static InputManager inputManager;

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
