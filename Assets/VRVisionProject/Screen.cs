using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public GameObject button;

    void Update()
    {
        GetComponent<TMPro.TextMeshPro>().text = button.GetComponent<Button>().stringInput;
    }
}
