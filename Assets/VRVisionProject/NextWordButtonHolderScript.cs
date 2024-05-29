using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextWordButtonHolderScript : MonoBehaviour
{
    public GameObject screen;
    private Button script;
    // Start is called before the first frame update
    void Start()
    {
        script = screen.GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.correctWordTyped)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
