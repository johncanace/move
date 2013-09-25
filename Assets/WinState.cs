using UnityEngine;
using System.Collections;

public class WinState : MonoBehaviour 
{
	void onTriggerEnter (Collider other)
	{
		Debug.Log ("You have completed this level.");
	}

	
	void onTriggerStay (Collider other)
	{
		Debug.Log ("You have beaten this level.");
	
	}
	
	
	void onTriggerExit (Collider other)
	{
		Debug.Log ("You have conquered this level.");
	
	}
}
