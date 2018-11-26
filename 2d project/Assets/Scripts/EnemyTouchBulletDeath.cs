using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTouchBulletDeath : MonoBehaviour {
    
    public int PointsToAddS; // points that will be added upon enemies death
    public float DestroyDelay; // how long until the enemy dies after touching layer
    public GameObject DeathParticle;

	private void Start()
	{
        
	}


	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.gameObject.layer==11) // if touching specified layer
        {
            Scoremanager.AddPoints(PointsToAddS); // adds points

            Destroy(gameObject, DestroyDelay); // Destroys on gameobject on delay
            Instantiate(DeathParticle, transform.position, transform.rotation);
        }
	}
}
