using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour {
    public float playerSpeed = 10f;
    public GameControl gameController;
    public GameObject bulletPrefab;
    public float reloadTime = 0.5f; //player can fire a bullet every half second
    float xPosition = 0.0f;
    int i=0;

    private float elapsedTime = 0;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        elapsedTime += Time.deltaTime;//keeping track of time for bullet firing
        float xMovement = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        xPosition = Mathf.Clamp(xMovement, -7f, 7f); 
        transform.Translate(xPosition, 0f, 0f);
        //keep the ship on screen
        if(transform.position.x < -7.0f)
        {
            transform.Translate(-xMovement,0f,0f);
        }else if(transform.position.x > 7.0f)
        {
            transform.Translate(-xMovement, 0f, 0f);
        }
  
        if (Input.GetButtonDown("Jump") && elapsedTime > reloadTime)
        {

            //Instantiate the bullet 1.2 units in front of the player
            // and in the foreground at Z = -5
            Vector3 spawnPos = transform.position;
            spawnPos += new Vector3(0, 1.2f, 0);
            Instantiate(bulletPrefab, spawnPos, Quaternion.identity);

            elapsedTime = 0f;// Reset bullet firing timer
        }
    }

    void OnTriggerEnter2D (Collider2D other){
        gameController.PlayerDied();

    }

     
}
