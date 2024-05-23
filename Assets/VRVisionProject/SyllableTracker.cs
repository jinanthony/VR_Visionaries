using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SyllableTracker : MonoBehaviour
{

    public XRBaseController leftController;
    public XRBaseController rightController;

    public void onClick(GameObject obj)
    {
        obj.SetActive(false);
        rightController.SendHapticImpulse(0.5f, 0.3f);
        leftController.SendHapticImpulse(0.5f, 0.3f);
    }
}
