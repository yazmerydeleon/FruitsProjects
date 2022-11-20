using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    [SerializeField]
    private Animator handAnimator;
    [SerializeField]
    private string gripButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(gripButton))
        {
            handAnimator.SetBool("Gripped", true);
        }

        if(Input.GetButtonUp(gripButton))
        {
            handAnimator.SetBool("Gripped", false);
        }
    }
}
