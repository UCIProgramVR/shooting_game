﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public Transform muzzle;
	public Projectile Projectile;
	public float msBetweenShots = 100;
	public float muzzleVelocity = 35;

	float nextShotTime;
	
	public void Shoot(){
		if (Time.time > nextShotTime){
			nextShotTime = Time.time + msBetweenShots / 1000;

		Projectile newProjectile = Instantiate(Projectile,muzzle.position,muzzle.rotation) as Projectile;
		newProjectile.SetSpeed(muzzleVelocity);
	 }
	}
}
