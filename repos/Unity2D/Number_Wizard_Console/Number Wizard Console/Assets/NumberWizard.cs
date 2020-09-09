using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start() {
        UnityEngine.Debug.Log("Welcome to number wizard");
        StartGame();               
    }

    void StartGame() {
        max = 1000;
        min = 1;
        guess = 500;
        
        UnityEngine.Debug.Log("Pick a number");
        UnityEngine.Debug.Log("Highest number is: " + max);
        UnityEngine.Debug.Log("Lowest number is: " + min);
        UnityEngine.Debug.Log("Is your number higher or lower than: " + guess + "?");
        UnityEngine.Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        max++;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            max = guess;
            guess = (max + min) / 2;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return)) {
            UnityEngine.Debug.Log("Great! Let's play again!");
            StartGame();
        }




    }

    void NextGuess() {
        guess = (max + min) / 2;
        UnityEngine.Debug.Log("Is your number higher or lower than: " + guess + "?");
    }
}
