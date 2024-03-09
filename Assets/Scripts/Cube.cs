using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{

    private string ShapeType = "Cube";
    [SerializeField]
    private double Edge = 2;

    // Override the GetName Method from the parent class Shape
    public override string GetName()
    {
        return ShapeType;
    }

    protected override double GetArea()
    {
        //Calculate the Area of a Cube
        return Math.Round(6 * (Edge * Edge));
    }
    private void OnMouseEnter()
    {
        ToolTipManager._instance.SetAndShowTooltip(GetName(), GetArea());
    }
    private void OnMouseExit()
    {
        ToolTipManager._instance.HideTooltip();


    }

}
