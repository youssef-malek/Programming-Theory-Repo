using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : Shape
{
    private string ShapeType = "Rectangle";
    [SerializeField]
    private double lenght = 2;
    [SerializeField]
    private double width = 3;
    [SerializeField]
    private double height = 4;
    // Start is called before the first frame update

    // Override the GetName Method from the parent class Shape
    public override string GetName()
    {
        return ShapeType;
    }
    protected override double GetArea()
    {
        //Calculate the Area of a Rectangle
        return System.Math.Round(2 * ((lenght * height) + (width * height) + (lenght * width)));
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
