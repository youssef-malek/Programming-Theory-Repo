using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylander : Shape
{
    private string ShapeType = "Cylinder";
    [SerializeField]
    private double Radius = 4;
    [SerializeField]
    private double Height = 6;

    // Start is called before the first frame update

    // Override the GetName Method from the parent class Shape
    public override string GetName()
    {
        return ShapeType;
    }

    protected override double GetArea()
    {
        //Calculate the Area of a Cylinder
        return Math.Round(2 * (Math.PI * Radius * Height) + 2 * (Math.PI * Radius * 2));

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
