using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintTip : MonoBehaviour
{
    private MeshRenderer paintTipRend;

    public Material colourMaterial;



    // Start is called before the first frame update
    void Start()
    {
        paintTipRend = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("PaintColour"))
        {
            colourMaterial = other.GetComponent<Renderer>().material;
            paintTipRend.material = colourMaterial;
        }
    }

}
