using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//private AudioSource GunShot;

//GunShot = GetComponent<AudioSource>();
public class BulletController : MonoBehaviour {
	public float speed;
	//public GameObject expEffect;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//GunShot.Play();
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
	}
}
