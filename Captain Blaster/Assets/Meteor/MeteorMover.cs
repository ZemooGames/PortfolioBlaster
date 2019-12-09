using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMover : MonoBehaviour {
    public float meteorSpeed;

    private Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        //give meteor an initial downward velocity
        meteorSpeed = Random.Range(-2.0f, -6.0f);
        rigidBody.velocity = new Vector2(0, meteorSpeed);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
