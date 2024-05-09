using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public string stringInput = "";

    private void Start()
    {
        stringInput = "";
    }

    public void onClick(string buttonName)
    {
        stringInput += buttonName;
        Debug.Log("I entered " + stringInput);
    }

    public void onEnter()
    {
        Debug.Log("I clicked enter!");
    }

    public void onDelete()
    {
        Debug.Log("I clicked delete!");
    }
}
