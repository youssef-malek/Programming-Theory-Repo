using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Device;

public class MainSceneUI : MonoBehaviour
{
    // Start is called before the first frame update
    public void QuitApplication()
    {

#if UNITY_EDITOR

#else


        Application.Quit();
#endif
    }
}
