using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    [SerializeField] private BoxCollider spawnArea;
    [SerializeField] GameManager gameManager;

    [SerializeField] private Transform startPoint;
    [SerializeField] private Transform endPoint;
    [SerializeField] private float speed;

    [SerializeField] private GameObject sphere;
    [SerializeField] private Color startColour;
    [SerializeField] private Color endColour;

    [SerializeField] private float  interpolationAmount;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("FoodItem"))
        {
            // Destroy the food item
            Destroy(collision.gameObject);

            // Move the target
            MoveTarget();

            // Add score
            gameManager.DisplayScore();
        }
    }
    
    private void MoveTarget()
    {
        var pointX = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        var pointY = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);
        var pointZ = Random.Range(spawnArea.bounds.min.z, spawnArea.bounds.max.z);

        transform.position = new Vector3(pointX, pointY, pointZ);

    }

    private void Update()
    {
        if(interpolationAmount > 1)
        {
            interpolationAmount = 0;
        }
        interpolationAmount += speed;

        sphere.GetComponent<MeshRenderer>().material.color = Color.Lerp(startColour, endColour, interpolationAmount);
        //transform.position = Vector3.Lerp(startPoint.position, endPoint.position, interpolationAmount);
    }
}
