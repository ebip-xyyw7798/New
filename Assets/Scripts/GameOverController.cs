using System.Collections;
using UnityEngine;

public class GameOverController : MonoBehaviour 
{
	public UI2Controller UI2Controller;

	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player")) 
		{
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			UI2Controller.ShowGameOverLabel();
		}
	}
}