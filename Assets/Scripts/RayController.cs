using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class RayController : MonoBehaviour
{
    [SerializeField]
    private string buttonName;

    [SerializeField]
    private LineRenderer lineRenderer;

    [SerializeField]
    private XRInteractorLineVisual lineVisual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(buttonName))
        {
            lineRenderer.enabled = true;
            lineVisual.enabled = true;
        }

        if (Input.GetButtonUp(buttonName))
        {
            lineRenderer.enabled = true;
            lineVisual.enabled = true;
        }
    }
}
