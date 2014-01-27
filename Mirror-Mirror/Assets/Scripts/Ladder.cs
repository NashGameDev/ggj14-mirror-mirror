using UnityEngine;
using System.Collections;

public class Ladder : MonoBehaviour 
{
	private PlatformerCharacter2D character;

	// Use this for initialization
	void Start () 
	{
		character = GameObject.Find("2D Character").GetComponent<PlatformerCharacter2D>();
	}
	
	void OnTriggerEnter2D(Collider2D col)
	{
		character.SetPlayerGravity (0f);
		character.isOnLadder = true;
		Debug.Log ("Enter ladder");
	}

	void OnTriggerExit2D(Collider2D col)
	{
		character.SetPlayerGravity (3f);
		character.isOnLadder = false;
		Debug.Log ("Exit ladder");
	}
}
