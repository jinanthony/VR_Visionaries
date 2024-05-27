using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;


public class Button : MonoBehaviour
{
    public string stringInput = "";
    public string[] wordBank = { "piano", "tiger", "horse", "sushi", "pineapple" };
    public int wordBankIndex = 0;

    public TextMeshPro screenText;

    public XRBaseController leftController;
    public XRBaseController rightController;


    private void Start()
    {
        stringInput = "";
    }

    public void onClick(string buttonName)
    {
        rightController.SendHapticImpulse(0.5f, 0.1f);
        leftController.SendHapticImpulse(0.5f, 0.1f);

        screenText.color = Color.black;
        stringInput += buttonName;
       // Debug.Log("I entered " + stringInput);
    }

    public void onEnter()
    {
        // Debug.Log("I clicked enter!");
        rightController.SendHapticImpulse(0.5f, 0.3f);
        leftController.SendHapticImpulse(0.5f, 0.3f);

        if (stringInput == wordBank[0])
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
        rightController.SendHapticImpulse(0.5f, 0.3f);
        leftController.SendHapticImpulse(0.5f, 0.3f);

        if (stringInput.Length > 0)
        {
            stringInput = stringInput.Substring(0, stringInput.Length - 1);
        }
    }
}
