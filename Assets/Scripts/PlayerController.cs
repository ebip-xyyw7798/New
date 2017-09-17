using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private void FixedUpdate ()
	{
		float x = Input.GetAxis ("Horizontal");
		float z = Input.GetAxis ("Vertical");	

		Rigidbody rigidbody = GetComponent<Rigidbody> ();

		rigidbody.AddForce (x * 10, 0, z * 10);

		if (Input.GetKeyDown ("space"))
			rigidbody.AddForce (Vector3.up * 150);
	}
}