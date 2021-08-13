﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/// <summary>
/// This script is to be attached to a GameObject called GameManager in the scene. It is to be used to manager the settings and overarching gameplay loop.
/// </summary>
public class GameManager : MonoBehaviour
{
    [Header("Scoring")]
    public int currentScore = 0; //The current score in this round.
    public int highScore = 0; //The highest score achieved either in this session or over the lifetime of the game.

    public TMP_Text currentScoreUI;

    [Header("Playable Area")]
    public float levelConstraintTop; //The maximum positive Y value of the playable space.
    public float levelConstraintBottom; //The maximum negative Y value of the playable space.
    public float levelConstraintLeft; //The maximum negative X value of the playable space.
    public float levelConstraintRight; //The maximum positive X value of the playablle space.

    [Header("Gameplay Loop")]
    public bool isGameRunning; //Is the gameplay part of the game current active?
    public float totalGameTime; //The maximum amount of time or the total time avilable to the player.
    public float gameTimeRemaining; //The current elapsed time

    [Header("Effects")]
    public GameObject bonusCollectEffect;

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore(-currentScore);
        currentScoreUI.text = "0";       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int scoreAmount)
    {
        currentScore += scoreAmount;
        currentScoreUI.text = currentScore.ToString();
    }

    public void CollectBonus(int amount, Vector2 pos)
    {
        UpdateScore(amount);
        Instantiate(bonusCollectEffect, pos, Quaternion.identity);
    }

}
