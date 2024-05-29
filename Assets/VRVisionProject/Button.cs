using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;


public class Button : MonoBehaviour
{
    public string stringInput = "";
    //public string[] wordBank = { "piano", "tiger", "horse", "sushi", "pineapple" };
    //public int wordBankIndex = 0;

    public TextMeshPro screenText;

    public XRBaseController leftController;
    public XRBaseController rightController;
    public bool correctWordTyped;

    public GameObject syllableSet;
    private GameObject thankYouBox;
    private GameObject suggestWordBox;
    private SyllableTracker syllableScript;
    private bool suggestWordModeEnabled;

    public void Start()
    {
        stringInput = "";
        correctWordTyped = false;
        syllableSet = GameObject.Find("Set of Syllables");
        thankYouBox = GameObject.Find("Thank You Message Holder");
        suggestWordBox = GameObject.Find("Suggest A Word Message Holder");
        syllableScript = syllableSet.GetComponent<SyllableTracker>();
        suggestWordModeEnabled = false;
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
        if (suggestWordModeEnabled)
        {
            stringInput = "";
            thankYouBox.transform.GetChild(0).gameObject.SetActive(true);
            suggestWordModeEnabled = false;
        }
        else
        {
            // Debug.Log("I clicked enter!");
            rightController.SendHapticImpulse(0.5f, 0.3f);
            leftController.SendHapticImpulse(0.5f, 0.3f);

            if (stringInput == WordProvider.GetCurrentWord())
            {
                // Debug.Log("right SPELLING");
                screenText.color = Color.green;
                correctWordTyped = true;
            }
            else
            {
                // Debug.Log("WRONG SPELLING");
                screenText.color = Color.red;
            }
        }            
    }

    public void onNext(Whiteboard board)
    {

        Debug.Log("Previous word:" + WordProvider.GetCurrentWord());
        WordProvider.IncrementWord();
        Debug.Log("Current word:" + WordProvider.GetCurrentWord());
        stringInput = "";
        board.resetBoard();
        correctWordTyped = false;

    }

    public void onStartOver(Whiteboard board)
    {
        stringInput = "";
        board.resetBoard();
        suggestWordModeEnabled = false;
        correctWordTyped = false;
        syllableScript.Start();
    }

    public void onSuggestWord()
    {
        stringInput = "";
        suggestWordModeEnabled = true;
        suggestWordBox.transform.GetChild(0).gameObject.SetActive(true);
    }

    public void oneSound()
    {

        rightController.SendHapticImpulse(0.5f, 0.1f);
        leftController.SendHapticImpulse(0.5f, 0.1f);


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
