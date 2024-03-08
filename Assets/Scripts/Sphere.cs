using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update
    private string ShapeType = "Sphere";
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
