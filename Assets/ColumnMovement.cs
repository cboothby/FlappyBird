using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnMovement : MonoBehaviour {

    Rigidbody2D col_rb; //creates a rigidbody variable for the columns
    public float col_speed; //creates a public editable variable for the speed at which the columns move
    Vector2 newPos; //creates a vector variable for where each created column will start
    public float range; //creates a public editable variable for the range of where each column will start

	// Use this for initialization
	void Start () {
        col_rb = GetComponent<Rigidbody2D>();
        col_rb.velocity = new Vector2(col_speed, 0f);
        newPos = transform.position;
        newPos.y = Random.Range(-range, range+0.5f);
        col_rb.MovePosition(newPos);

	}
	
	// Update is called once per frame
	void Update () {

        Vector2 col_pos = Camera.main.WorldToScreenPoint(transform.position);
        if(col_pos.x < 0f)
        {
            Destroy(gameObject, 1f);
        }
		
	}
}
