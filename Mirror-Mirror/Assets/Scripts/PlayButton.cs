using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour 
{
	Sprite buttonImg01;
	public Sprite buttonImg02;

	// Use this for initialization
	void Start () 
	{
		buttonImg01 = GetComponent<SpriteRenderer> ().sprite;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void OnMouseEnter()
	{
		GetComponent<SpriteRenderer>().sprite = buttonImg02;
	}

	void OnMouseExit()
	{
		GetComponent<SpriteRenderer>().sprite = buttonImg01;
	}

	void OnMouseDown()
	{
		//GetComponent<SpriteRenderer>().color = new Color (1.0f, 0f, 0f);
		GetComponent<SpriteRenderer>().sprite = buttonImg01;
	}

	void OnMouseUpAsButton()
	{
		Debug.Log ("Goning to GameEngine");
		Application.LoadLevel ("GameEngine");
	}
}
