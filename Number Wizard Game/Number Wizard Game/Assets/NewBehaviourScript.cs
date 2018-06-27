using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    // Use this for initialization
    int guess;
    int max;
    int min;
	void Start ()
    {
        max = 500;
        min = 1;
        guess = (max + min) / 2;
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Please think of a number between 1 to 500");
        Debug.Log("Press Up arrow for higher, Down arrow for lower and Enter for Correct guess");
        Debug.Log("Is the number higher, lower or equal to "+ guess);
    }	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is the number higher, lower or equal to " + guess);
        }           
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is the number higher, lower or equal to " + guess);
        }
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            print("Yey");
        }            
    }
}
