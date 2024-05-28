using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicModelSelector : MonoBehaviour
{
    public GameObject pianoPrefab;
    public GameObject tigerPrefab;
    public GameObject horsePrefab;
    public GameObject hamburgerPrefab;
    public GameObject bananaPrefab;
    public GameObject practiceModel;
    public GameObject testModel;

    void Start()
    {
        if (WordProvider.GetCurrentWord() == "piano")
        {
            practiceModel = Instantiate(pianoPrefab, new Vector3(-13.3f, -0.03f, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            testModel = Instantiate(pianoPrefab, new Vector3(10.34f, -0.03f, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
        }
        else if (WordProvider.GetCurrentWord() == "tiger")
        {
            practiceModel = Instantiate(tigerPrefab, new Vector3(-13.3f, -0.03f, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            testModel = Instantiate(tigerPrefab, new Vector3(10.34f, -0.03f, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
        }
        else if (WordProvider.GetCurrentWord() == "horse")
        {
            practiceModel = Instantiate(horsePrefab, new Vector3(-13.3f, -0.03f, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            testModel = Instantiate(horsePrefab, new Vector3(10.34f, -0.03f, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
        }
        else if (WordProvider.GetCurrentWord() == "hamburger")
        {
            practiceModel = Instantiate(hamburgerPrefab, new Vector3(-13.3f, 0, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            testModel = Instantiate(hamburgerPrefab, new Vector3(10.34f, 0, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
            practiceModel.transform.localScale = new Vector3(5, 5, 5);
            testModel.transform.localScale = new Vector3(5, 5, 5);
        }
        else if (WordProvider.GetCurrentWord() == "banana")
        {
            practiceModel = Instantiate(bananaPrefab, new Vector3(-13.3f, 0, -2.91f), Quaternion.Euler(0, 0, 0), this.transform);
            testModel = Instantiate(bananaPrefab, new Vector3(10.34f, 0, 9.99f), Quaternion.Euler(0, -180, 0), this.transform);
            practiceModel.transform.localScale = new Vector3(5, 5, 5);
            testModel.transform.localScale = new Vector3(5, 5, 5);
        }
    }

    // Update is called once per frame
    void Update()
    {
        practiceModel.SetActive(false);
        testModel.SetActive(false);
        Start();
    }
}
