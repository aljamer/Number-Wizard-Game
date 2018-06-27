using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    // Use this for initialization
    int guess;
    int max = 1;
    int min = 500;
    void Start()
    {
        guess = (max + min) / 2;
        //  System.Console.WriteLine("hello world");
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Please think of a number between 1 to 500");
        Debug.Log("Press Up arrow for higher, Down arrow for lower and Space for Correct guess");
        Debug.Log("Is the number higher, lower or equal to " + guess);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            Debug.Log("Is the number higher, lower or equal to " + guess);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            Debug.Log("Is the number higher, lower or equal to " + guess);
        }
       if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            print("Yey");
    }
}