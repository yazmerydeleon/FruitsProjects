using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashLightGrabController : XRGrabInteractable
{
    [SerializeField] private GameObject spotLight;
    [SerializeField] private MeshRenderer flashLightScreen;

    [SerializeField] private Material flashLight, defaultFlashLight;

    bool isOn;

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);

        if (isOn)
        {
            spotLight.SetActive(false);
            flashLightScreen.material = defaultFlashLight;
            isOn = false;
        }
        else
        {
            spotLight.SetActive(true);
            flashLightScreen.material = flashLight;
            isOn = true;
        }

    }
}
