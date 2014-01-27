using UnityEngine;
using System.Collections;

public class EnemyBulletScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Destroy the enemy bullet if it goes outside the screen...
		if((transform.position.y > Camera.main.ScreenToWorldPoint (new Vector3 (0f, Screen.height, 0f)).y) || /* on the top    */
		   (transform.position.y < Camera.main.ScreenToWorldPoint (new Vector3 (0f, 0f, 0f)).y) ||            /* on the bottom */
		   (transform.position.x < Camera.main.ScreenToWorldPoint (new Vector3 (20f, 0f, 0f)).x) ||            /* on the left   */
		   (transform.position.x > Camera.main.ScreenToWorldPoint (new Vector3 (Screen.width, 0f, 0f)).x))    /* on the right  */
		{
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D (Collider2D col) 
	{
		// If it hit the Player
		if(col.tag == "Shield")
		{
			// Destroy the enemy bullet
			Destroy (gameObject);
		}
	}
}
