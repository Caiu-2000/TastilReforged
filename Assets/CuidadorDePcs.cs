using UnityEngine;

public class CuidadorDePcs : MonoBehaviour
{

#if UNITY_EDITOR
    public int targetFPS = 120;

    void Awake()
    {
        // 1. Turn off VSync (Required for targetFrameRate to work)
        QualitySettings.vSyncCount = 0;

        // 2. Set the desired framerate cap
        Application.targetFrameRate = targetFPS;
    }

#endif


}
