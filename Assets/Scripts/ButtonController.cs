using System.Collections;
using UnityEngine;

public class ButtonController : MonoBehaviour 
{
	public UI3Controller UI3Controller;

	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player")) 
		{
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			UI3Controller.Showbutton();
		}
	}
}