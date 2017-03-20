using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour {

    Rigidbody2D birdy; //creates rigidbody variable for the bird
    public float force; //creates variable for the amount of force to be applied to the bird
    Vector2 upForce;
    Vector3 birdpos;
    enum BirdState { STARTING, PLAYING, DEAD}
    BirdState state;

	// Use this for initialization
	void Start () {
        birdy = GetComponent<Rigidbody2D>();
        upForce = new Vector2(0f, force);
        state = BirdState.STARTING;

	}
	
	// Update is called once per frame
	void Update () {


        switch (state)
        {
            case BirdState.STARTING:
                Time.timeScale = 0f;

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Time.timeScale = 1f;
                    state = BirdState.PLAYING;
                    Jump();
                }

                break;

            case BirdState.PLAYING:

                if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
                {
                    Jump();
                }

                birdpos = Camera.main.WorldToScreenPoint(transform.position);

                if (birdpos.y > Screen.height || birdpos.y < 0)
                {
                    state = BirdState.DEAD;
                }

                break;

            case BirdState.DEAD:

                Die();

                break;
        }

	}

    void Jump()
    {
        birdy.velocity = new Vector2(0f, 0f);
        birdy.AddForce(upForce);
    }

    void Die()
    {
        Debug.Log("U DEID");
    }




}
