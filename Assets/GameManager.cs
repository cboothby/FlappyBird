using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject columns; //creates variable for the columns
    public float repeatingTime; //creates variable for the amount of time in between column spawns (edited in the inspector)
    public static float score = 0;

    public Text scoreText;

	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerateColumns", 1f, repeatingTime); //calls GenerateColumns after one second, then again after the specified repeatingTime
        score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score: " + score;
	}
    
    void GenerateColumns() //creating a function for generating multiple columns
    {
        Instantiate(columns, transform.position, Quaternion.identity);
    }
}
