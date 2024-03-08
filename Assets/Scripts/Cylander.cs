using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylander : Shape
{
    private string ShapeType = "Cylinder";
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
