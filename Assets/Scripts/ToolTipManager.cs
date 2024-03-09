using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ToolTipManager : MonoBehaviour
{
    public static ToolTipManager _instance;
    public TextMeshProUGUI toolTip;
    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);

        }
        else
        {
            _instance = this;
        }
    }
    private void Start()
    {
        Cursor.visible = true;
        gameObject.SetActive(false);
    }
    private void Update()
    {
        transform.position = Input.mousePosition;
    }

    public void SetAndShowTooltip(string message, double area)
    {
        gameObject.SetActive(true);
        toolTip.text = "{ " + message + " <> Surface Area = " + area + " m2} ";
    }
    public void HideTooltip()
    {
        gameObject.SetActive(false);
        toolTip.text = string.Empty;
    }
}
