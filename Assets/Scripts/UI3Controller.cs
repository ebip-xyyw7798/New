using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UI3Controller : MonoBehaviour 
{
	public Button button;

	private void Start () 
	{
		button.gameObject.SetActive(false);	
	}

	public void Showbutton()
	{
		button.gameObject.SetActive(true);
	}
}