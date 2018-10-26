using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew : MonoBehaviour {

    public float Speed;
   
    public Rigidbody2D pc;
    // public
    public GameObject EnemyDeath;
    public bool deadClone = false;
    public GameObject ProjectileParticle;
    public int PointsforKill;
    float currCountdownValue;
  //  public float startTime;
   

    // Use this for initialization


	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);

    } // end update

	
	void OnTriggerEnter2D(Collider2D other)
	{
        if(other.tag == "Enemy"){
            Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Scoremanager.AddPoints(PointsforKill);
        } // ends if


        Instantiate(ProjectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
    } // ends ontrigger 


}
