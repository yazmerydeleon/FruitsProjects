using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject fruitObject;
    [SerializeField]
    private TMP_Text scoreText;
    [SerializeField]
    private Transform spawnPoint;

    private int score = 0;
    public void SpawnFood()
    {
        Instantiate(fruitObject, spawnPoint.position, spawnPoint.rotation);
    }

    public void DisplayScore()
    {
        //Add score
        score++;
        
        //Display the score
        scoreText.SetText("" + score);
    }
}
