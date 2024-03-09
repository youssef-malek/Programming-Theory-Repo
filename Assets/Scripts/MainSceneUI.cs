using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.Device;
using UnityEngine.UI;

public class MainSceneUI : MonoBehaviour
{

    public Button QuitButton;
    public TextMeshProUGUI PlayerName;
    private void Start()
    {
        PlayerName.text = "Hi: " + GameManager.Instance.PlayerName;
        QuitButton.onClick.AddListener(QuitApplication);
    }

    // Start is cal led before the first frame update
    public void QuitApplication()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
       Application.Quit();
# endif
    }
}
