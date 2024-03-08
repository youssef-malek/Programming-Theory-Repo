using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Shape
{
    private string ShapeType = "Rectangle";
    // Start is called before the first frame update


    private void OnMouseEnter()
    {
        ToolTipManager._instance.SetAndShowTooltip(ShapeType);
    }
    private void OnMouseExit()
    {
        ToolTipManager._instance.HideTooltip();


    }
}
