using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private int ID_sahpe;
    protected string ShapeName;
    protected Color color;


    protected virtual void Area()
    {

    }
    public virtual string GetName()
    {
        return "Shape";
    }



    protected abstract double GetArea();
}
