using UnityEngine;
using System.Collections;

public class IconFollow : MonoBehaviour {

	/*
	 *  This script makes it so that the image plane of an icon is always following/facing the player camera.
	 */

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//Constantly updates the position of the icons
	void Update () {
		transform.up = Camera.main.transform.position - transform.position;
		transform.forward = -Camera.main.transform.up;
	}
}
