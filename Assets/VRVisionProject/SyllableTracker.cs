using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;

public class SyllableTracker : MonoBehaviour
{

    public XRBaseController leftController;
    public XRBaseController rightController;

    public List<GameObject> syllables;
    public GameObject syllablePrefab;
    public GameObject newPrefabInstance;
    public string currentWord;

    public void Start()
    {
        foreach (GameObject obj in syllables)
        {
            obj.SetActive(true);
        }

        List<string> currentWordSyllables = WordProvider.GetSyllables();
        currentWord = WordProvider.GetCurrentWord();

        for (int i = 0; i < currentWordSyllables.Count; i++)
        {
            newPrefabInstance = Instantiate(syllablePrefab, new Vector3(0.908f + -13.77f, 1.65f + 0.57f, 5.77f + -5.06f + 3.59f * i), Quaternion.identity, this.transform);
            TextMeshPro tmp = newPrefabInstance.GetComponentInChildren<TextMeshPro>();
            tmp.text = currentWordSyllables[i];
        }
    }

    public void Update()
    {
        if (currentWord != WordProvider.GetCurrentWord())
        {
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(false);
            }
            Start();
        }
    }

    public void onClick(GameObject obj)
    {
        obj.SetActive(false);
        Debug.Log("debugging:" + obj);
        rightController.SendHapticImpulse(0.5f, 0.3f);
        leftController.SendHapticImpulse(0.5f, 0.3f);
    }
}
