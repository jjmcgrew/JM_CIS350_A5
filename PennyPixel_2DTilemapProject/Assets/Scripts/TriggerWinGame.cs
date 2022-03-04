/*
 * Josh McGrew
 * Assignment 5A
 * win the game when the player hits attached trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWinGame : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        UIManager.wonGame = true;
    }
}