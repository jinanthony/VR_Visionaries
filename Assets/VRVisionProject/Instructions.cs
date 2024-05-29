using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{

    public string instructions = "Welcome to our game. \nToday we will be practicing our spelling. \n Navigate to your left, the practice zone by teleporting, and \nread the instructions on the left side of \nthe wall first to continue. If you need to click to \ndraw on the whiteboard, type letters, or\n teleport, use the inner button on the remotes.";

    public void onClickWelcome()
    {
        instructions = "Welcome to our game. \nToday we will be practicing our spelling. \n Navigate to your left, the practice zone by teleporting, and \nread the instructions on the left side of \nthe wall first to continue. If you need to click to \ndraw on the whiteboard, type letters, or\n teleport, use the inner button on the remotes.";
    }

    public void onClickWord()
    {
        instructions = "Locate the object in this area. This is the\n word you will spell. First, practice sounding\n out each syllable in the word out loud. Then\n click the board with that syllable. Once you\n are done, navigate to the right side of the\n wall to get the next instructions.";
    }

    public void onClickWrite()
    {
        instructions = "Now, we will practice writing. Grab the \nmarker.Write the corresponding letter for\n each syllable in the correct whiteboard.\n Then teleport to the test zone behind you.";
    }

    public void onClickTest()
    {
        instructions = "Type the letters using the keyboard. Click Enter when done.\n The screen will let you know if you \nhave spelled the word correctly.";
    }

    public void onClickNext()
    {
        Debug.Log("Previous word:" + WordProvider.GetCurrentWord());
        WordProvider.IncrementWord();
        Debug.Log("Current word:" + WordProvider.GetCurrentWord());
    }

    void Update()
    {
        string formattedInstructions = instructions.Replace("\\n", "\n");

        GetComponent<TMPro.TextMeshPro>().text = formattedInstructions;
    }
}
