using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
 
    private float NextAction;

    public Transform firePoint;

    public GameObject projectile;


	private void Start()
	{
        projectile = Resources.Load("Prefabs/projectile") as GameObject;
	}



	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Instantiate(projectile, firePoint.position, firePoint.rotation);

        }
	}

}
