using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour {

	public bool isFiring;
	//public GameObject expEffect;
	public BulletController bullet;
	public float bulletSpeed;
	public float timeBetweenShots;
	public float shotCounter;
	//public ImageController image;
	public GameObject explosionPrefab;
	public Transform firePoint;
	private AudioSource GunShot;
	// Use this for initialization
	void Start () {
		GunShot = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	//GunShot = GetComponent<AudioSource>();
	void Update () {
		if(isFiring){
			shotCounter -= Time.deltaTime ;
			if(shotCounter <= 0){
				shotCounter = timeBetweenShots;
				GunShot.Play();
				Instantiate(explosionPrefab,firePoint.position,Quaternion.identity);
				//Instantiate(expEffect, firePoint.position,firePoint.rotation);
				BulletController newBullet = Instantiate(bullet,firePoint.position,firePoint.rotation) as BulletController;

				newBullet.speed = bulletSpeed;
			}

		}
		else{
			shotCounter = 0;
		}
	}
}
