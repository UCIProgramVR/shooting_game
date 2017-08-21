using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{

	Rigidbody myRigidBody;
	Vector3 velocity;

	void Start()
	{
		myRigidBody = GetComponent<Rigidbody>();
	}

	public void Move(Vector3 _velocity)
	{
		velocity = _velocity;
	}


	public void FixedUpdate()
	{
        myRigidBody.MovePosition(myRigidBody.position + velocity * Time.deltaTime);
	}

	public void LookAt(Vector3 LookPoint)
	{
		Vector3 heightCorrectedPoint = new Vector3(LookPoint.x, transform.position.y, LookPoint.z);
        //Camera.main.WorldToScreenPoint(heightCorrectedPoint);
		transform.LookAt(heightCorrectedPoint);
	}
}
