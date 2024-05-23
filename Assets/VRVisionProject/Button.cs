using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    public string stringInput = "";

    public TextMeshPro screenText;

    private void Start()
    {
        stringInput = "";
    }

    public void onClick(string buttonName)
    {
        screenText.color = Color.black;
        stringInput += buttonName;
       // Debug.Log("I entered " + stringInput);
    }

    public void onEnter()
    {
        // Debug.Log("I clicked enter!");

        if(stringInput == "piano")
        {
           // Debug.Log("right SPELLING");
            screenText.color = Color.green;
        } else
        {
          // Debug.Log("WRONG SPELLING");
            screenText.color = Color.red;
        }
            
    }

    public void onDelete()
    {
        //Debug.Log("I clicked delete!");
        if (stringInput.Length > 0)
        {
            stringInput = stringInput.Substring(0, stringInput.Length - 1);
        }
    }
}
