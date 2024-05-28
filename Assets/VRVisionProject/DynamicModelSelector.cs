using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicModelSelector : MonoBehaviour
{
    public GameObject pianoPrefab;
    public GameObject tigerPrefab;
    public GameObject horsePrefab;
    public GameObject sushiPrefab;
    public GameObject pineapplePrefab;

    void Start()
    {
        if (WordProvider.GetCurrentWord() == "piano")
        {
            GameObject practiceModel = Instantiate(pianoPrefab, new Vector3(-13.3f, -0.03f, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            GameObject testModel = Instantiate(pianoPrefab, new Vector3(10.34f, -0.03f, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
        }
        else if (WordProvider.GetCurrentWord() == "tiger")
        {
            GameObject practiceModel = Instantiate(tigerPrefab, new Vector3(-13.3f, -0.03f, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            GameObject testModel = Instantiate(tigerPrefab, new Vector3(10.34f, -0.03f, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
        }
        else if (WordProvider.GetCurrentWord() == "horse")
        {
            GameObject practiceModel = Instantiate(horsePrefab, new Vector3(-13.3f, -0.03f, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            GameObject testModel = Instantiate(horsePrefab, new Vector3(10.34f, -0.03f, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
        }
        else if (WordProvider.GetCurrentWord() == "sushi")
        {
            GameObject practiceModel = Instantiate(sushiPrefab, new Vector3(-13.3f, 0.5f, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            GameObject testModel = Instantiate(sushiPrefab, new Vector3(10.34f, 0.5f, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
            practiceModel.transform.localScale = new Vector3(20, 20, 20);
            testModel.transform.localScale = new Vector3(20, 20, 20);
        }
        else if (WordProvider.GetCurrentWord() == "pineapple")
        {
            GameObject practiceModel = Instantiate(pineapplePrefab, new Vector3(-13.3f, 1.2f, -2.91f), Quaternion.Euler(0, 90, 0), this.transform);
            GameObject testModel = Instantiate(pineapplePrefab, new Vector3(10.34f, 1.2f, 9.99f), Quaternion.Euler(0, -90, 0), this.transform);
            practiceModel.transform.localScale = new Vector3(15, 15, 15);
            testModel.transform.localScale = new Vector3(15, 15, 15);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
