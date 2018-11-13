using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew : MonoBehaviour {

    public float Speed;

    public float timeOut;
    public GameObject pc;
    // public
    public GameObject EnemyDeath;
    public bool deadClone = false;
    public GameObject projectileParticle;
    public int PointsforKill;
    float currCountdownValue;

    // adds time varailbe
    public float startTime = 0;

	// Use this for initialization
	private void Start()
	{
        pc = GameObject.Find("pc");

        EnemyDeath = Resources.Load("Prefabs/DeathP") as GameObject;

        projectileParticle = Resources.Load("Prefabs/bulletParticle") as GameObject;

        if(pc.transform.localScale.x > 0) {
            Speed = -Speed;
        }
        Destroy(GameObject.Find("projectile(Clone)"), timeOut); 
	}

	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
        startTime += Time.deltaTime;



    } // end update

	
	void OnTriggerEnter2D(Collider2D other)
	{
        float time = startTime;
        if(other.tag == "Enemy"){
            Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            Scoremanager.AddPoints(PointsforKill);
        } // ends if
        Destroy(GameObject.Find("projectile(Clone)"), timeOut); 
        //else if (time >= 2) { // Destroy the clone
        //    Destroy(GameObject.Find("projectile(Clone)"));
        //    startTime = 0;
        //} // ends else if


    } // ends ontrigger 
 void OnCollisionEnter2D (Collision other)
	{
        Instantiate(ProjectileParticle, transform.position, transform.rotation);
        Destroy(gameObject);
	}

}
