using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackground : MonoBehaviour {
    public float scrollSpeed = -2f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, scrollSpeed * Time.deltaTime, 0f);
        if(transform.position.y <= -20)
        {
            transform.Translate(0f, 40f, 0f);
        }
	}
}
