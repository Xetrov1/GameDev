
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckPoint;

    private Rigidbody2D pc;

    // particles
    public GameObject deathParticles;

    public GameObject respawnParticles;

    // Respawn Delay
    public float respawnDelay;

    // point penalty on death
    public int pointPenaltyOnDeath;

    // Store Gravity Value
    private float gravityStore;

	// Use this for initialization
	void Start () {
        pc = FindObjectOfType<Rigidbody2D>();
	}
    public void RespawnPlayer() {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo(){
        // generte death particles
        Instantiate(deathParticles, pc.transform.position, pc.transform.rotation);// first thing we want created is death particle
        // hide player
     //   pc.enabled = false;
        pc.GetComponent<Renderer>().enabled = false;
        // gravity reset
        gravityStore = pc.GetComponent<Rigidbody2D>().gravityScale;
        pc.GetComponent<Rigidbody2D>().gravityScale = 0f;
        pc.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        // Point Penalty
        Scoremanager.AddPoints(-pointPenaltyOnDeath);
        // Debug Message
        Debug.Log("Player Respawn");
        // Respawn Delay
        yield return new WaitForSeconds(respawnDelay);
        // Gravity Restore
        pc.GetComponent<Rigidbody2D>().gravityScale = gravityStore;
        // Match Players transform position
        pc.transform.position = currentCheckPoint.transform.position;
        // show player
       //  pc.enabled = true;
        pc.GetComponent<Renderer>().enabled = true;
        //spawn pc
        Instantiate(respawnParticles, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }
	// Update is called once per frame
	void Update () {
	
	}
}
/*   
 *     |
 *     |
 *     |
 *     |
 *     |
 *     |
 *     |
 *     |
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */