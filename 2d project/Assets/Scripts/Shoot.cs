﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {


    public Transform firePoint;

    public GameObject projectile;
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Mouse0)) {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
        }
	}
}
