using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DinoStateController : StateController
{
    public PowerupType currentPowerupType = PowerupType.Default;
    public PlayerState shouldBeNextState = PlayerState.Normal;
    public UnityEvent IncreaseScoreMultiplierEvent;
    public UnityEvent ResetScoreMultiplierEvent;


    public override void Start()
    {
        base.Start();
        GameRestart(); // clear powerup in the beginning, go to start state
    }

    // this should be added to the GameRestart EventListener as callback
    public void GameRestart()
    {
        // clear powerup
        currentPowerupType = PowerupType.Default;
        // set the start state
        TransitionToState(startState);
    }

    public void SetPowerup(PowerupType i)
    {
        currentPowerupType = i;
    }

}