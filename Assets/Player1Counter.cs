using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Counter : MonoBehaviour
{   
    int score;

    void Start()
    {
        score = 0; // Initialize score
        Debug.Log("Player1Score: " + score);
    }

    void Update()
    {
        if (transform.position.x > 10.3f)
        {
            AddScore(1);
        }
    }

    void AddScore(int points)
    {
        score += points;
        Debug.Log("Player1Score: " + score);
    }

    
}
