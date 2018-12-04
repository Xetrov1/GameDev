using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew : MonoBehaviour {

    public float Speed;

    //public float timeOut;
    public GameObject pc;
    // public
    public GameObject EnemyDeath;
    public bool deadClone = false;
    public GameObject projectileParticle;
    public int PointsforKill;
    float currCountdownValue;

    // adds time varailbe
    //public float startTime = 0;

	// Use this for initialization
	private void Start()
	{
        pc = Resources.Load("Prefabs/pc") as GameObject;

        EnemyDeath = Resources.Load("Prefabs/DeathP") as GameObject;


        if(pc.transform.localScale.x > 0) {
            Speed = -Speed;
        }
        //Destroy(GameObject.Find("projectile(Clone)"), timeOut); 
	}

	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);



    } // end update
 //   } // ends ontrigger 
 void OnCollisionEnter2D (Collision2D other)
	{
        Instantiate(projectileParticle, transform.position, transform.rotation);
    // Destroy(gameObject);
	}

}
