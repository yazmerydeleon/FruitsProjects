using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PaintBrushGrabInteractable : XRGrabInteractable
{
    [SerializeField] private GameObject paintPrefab;
    [SerializeField] private Transform paintTip;
    [SerializeField] private PaintTip tip;

    private GameObject spawnedPaint;

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);

        spawnedPaint = Instantiate(paintPrefab, paintTip.position, paintTip.rotation);
        spawnedPaint.transform.SetParent(paintTip);

        if(tip.colourMaterial != null)
        {
            spawnedPaint.GetComponent<TrailRenderer>().material = tip.colourMaterial;
        }
    }

    protected override void OnDeactivated(DeactivateEventArgs args)
    {
        base.OnDeactivated(args);

        if(spawnedPaint != null)
        {
            spawnedPaint.transform.SetParent(null); 
            spawnedPaint = null;
        }
    }
}
