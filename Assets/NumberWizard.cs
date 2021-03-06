﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 0;
    int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // 
    void StartGame()
    {
        Debug.Log("What's the craic, numba wizaaard?");
        Debug.Log("Pick a number!");
        Debug.Log($"Highest Number you can pick is {max}");
        Debug.Log($"Lowest Number is {min}");
        Debug.Log($"Tell me if your number is higher or lower than my {guess}?");
        Debug.Log("Up Arrow = Higher; Down arrow = Lower; Enter = Correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        } 
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am brilliant");
            StartGame();
        }
    }

    // Calculate the next guess
    void NextGuess() 
    {
        guess = (max + min) / 2;
        Debug.Log($"Is it higher or lower than {guess}?");
    }
}
