using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WelcomeUIHandler : MonoBehaviour
{
    public Button StartButton;
    public Button ExitButton;
    public TMP_InputField NameInputField;

    private void Start()
    {
        StartButton.onClick.AddListener(StartGame);
        ExitButton.onClick.AddListener(QuitApplication);
    }
    public void StartGame()
    {
        GameManager.Instance.PlayerName = NameInputField.text;
        SceneManager.LoadScene(1);
    }
    public void QuitApplication()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
       Application.Quit();
# endif
    }
}
