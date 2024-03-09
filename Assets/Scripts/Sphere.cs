using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Sphere : Shape
{
    // Start is called before the first frame update
    private static string ShapeType = "Sphere";

    private double m_Radius = 5;
    public double Radius
    {
        get { return m_Radius; }
        set { m_Radius = value; }
    }
    // Start is called before the first frame update


    public override string GetName()
    {
        return ShapeType;
    }

    protected override double GetArea()
    {

        //Calculate the Area of a sphere
        return Math.Round(4 * Math.Pow(Radius, 2) * Mathf.PI);
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
