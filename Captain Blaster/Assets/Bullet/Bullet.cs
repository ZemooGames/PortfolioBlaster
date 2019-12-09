using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float speed = 10f;
    private GameControl gameController;//private this time

	// Use this for initialization
	void Start () {
        gameController = GameObject.FindObjectOfType<GameControl>();
        print(gameController);

    }

    // Update is called once per frame
    void Update () {
        transform.Translate(0f, speed * Time.deltaTime, 0f);
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        gameController.AddScore();
        Destroy(gameObject);
    } 
}
