﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//THIS SCRIPT IS ATTACHED TO THE DATA MANAGER OBJECT PRESENT IN THE SCENES

public class KeepData : MonoBehaviour
{
    public static string PlayerName; // STATIC so it is preserved between classes
    public InputField PlayerNameInput;
    public Text showPlayerName;
    public static float PlayerScore;
    public Text showPlayerScore;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject); // don't destroy this game object when a new scene is loaded.
    }

    public void UpdateName() //executed in each letter change
    {
        PlayerName = PlayerNameInput.text; // assign new input text to string
        Debug.Log(PlayerName); //prints updated name to log on each letter change
        showPlayerName.text = PlayerName; // show string in the textbox just to see that it works in the Intro scene. 
    }

    public void UpdateScore() //executed in each letter change
    {
        PlayerScore = 0f; // assign new input text to string
        Debug.Log(PlayerScore); //prints updated name to log on each letter change
        showPlayerScore.text = PlayerName + ": " + PlayerScore; // show string in the textbox just to see that it works in the Intro scene. 
    }

    public void ShowName()
    {
        showPlayerName.text = PlayerName;
        Debug.Log(PlayerName);
    }

    public void ShowScore()
    {
        showPlayerScore.text = PlayerName + ": " + PlayerScore;
        Debug.Log(PlayerScore);

    }

}