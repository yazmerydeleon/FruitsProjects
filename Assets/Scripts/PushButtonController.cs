using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushButtonController : MonoBehaviour
{
    [SerializeField] private Transform button, upPosition, downPosition;

    [SerializeField] private float movementSpeed = 0.3f;

    public UnityEvent handIn, handOut;

    Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        button.position = upPosition.position;
        targetPosition = upPosition.position;
    }

    public void OnHandIn()
    {
        targetPosition = downPosition.position;
        handIn?.Invoke();
    }

    public void OnHandOut()
    {
        targetPosition = upPosition.position;
        handOut?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        button.position = Vector3.Lerp(button.position, targetPosition, movementSpeed);
    }
}
