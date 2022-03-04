/*
 * Josh McGrew
 * Assignment 5A
 * add score with trigger
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAddScore : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        UIManager.score++;
    }
}
