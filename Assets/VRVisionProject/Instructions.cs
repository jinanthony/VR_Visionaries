using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{

    public string instructions = "Weclome To ReadMe.\nToday we will practice our spelling.\nClick to Continue.";


    public void onClickWelcome()
    {
        instructions = "Navigate to the Practice Zone.\nTeleport to the zone on the left.";
    }

    public void onClickWord()
    {
        instructions = "Sound out each syllable in the \nword out load.\nThen click the board with that syllable.";
    }

    public void onClickWrite()
    {
        instructions = "Grab the marker.\nWrite the corresponding letter for each \nsyllable in the correct whiteboard.\n Then teleport to the test zone.";
    }

    public void onClickTest()
    {
        instructions = "Click Enter when done.\n The screen will let you know if you \nhave spelled the word correctly.";
    }

    void Update()
    {
        string formattedInstructions = instructions.Replace("\\n", "\n");

        GetComponent<TMPro.TextMeshPro>().text = formattedInstructions;
    }
}
