using UnityEngine;
using System.Collections;

public class EnemyGun : MonoBehaviour 
{
	public Rigidbody2D enemyBulletPrefab; // Prefab of enemyBullet.
	public float speed = 0.0f;// The speed the enemyBullet will fire at.

	// Use this for initialization
	void Start () 
	{
		Invoke ("FireEnemyBullet", 1f);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void FireEnemyBullet()
	{
		// ... instantiate the rocket facing right and set it's velocity to the right. 
		Rigidbody2D bulletInstance = Instantiate(enemyBulletPrefab, transform.position, Quaternion.Euler(new Vector3(0,0,0))) as Rigidbody2D;

		bulletInstance.velocity = new Vector2 (speed, 0f);

		Invoke ("FireEnemyBullet", 1f);
	}
}
