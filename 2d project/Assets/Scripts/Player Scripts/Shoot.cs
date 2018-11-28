using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    // bullets life
    public float Period;
    private float NextAction;

    public Transform firePoint;

    public GameObject projectile;


	private void Start()
	{
        //projectile = Resources.Load("Prefabs/Projectile") as GameObject;
	}



	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
           // Spawn();
        }
	}

    /*private void FixedUpdate()
    {
        if (NextAction <= Time.time)
        {
            Destroy(GameObject.Find("projectile(clone)"));
        }
    }
    void Spawn()
    {

        NextAction = (Time.time + Period);
    } */
}
