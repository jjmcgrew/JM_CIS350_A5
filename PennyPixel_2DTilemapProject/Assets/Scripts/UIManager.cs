/*
 * Josh McGrew
 * Assignment 5A
 * UI manager script
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text winText;
    public static int score;
    public static bool wonGame = false;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score;
        if (wonGame)
        {
            winText.text = "You Win!";
        }
    }
}
