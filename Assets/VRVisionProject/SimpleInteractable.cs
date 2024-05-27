using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SimpleInteractable : XRBaseInteractable
{
    public XRBaseController leftController;
    public XRBaseController rightController;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        gameObject.SetActive(false);
        Debug.Log("deactivating syllable");
        rightController.SendHapticImpulse(0.5f, 0.3f);
        leftController.SendHapticImpulse(0.5f, 0.3f);
    }
}
