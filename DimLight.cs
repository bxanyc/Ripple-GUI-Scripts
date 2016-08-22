using UnityEngine;
using System.Collections;

public class DimLight : MonoBehaviour {

	/*
	 *  This script is in charge of the point light halo glow effect 
	 *  that is placed on icons inside of the environment. As the player 
	 *  controlled fish gets close to an icon, the glow will fade away, 
	 *  and reverts when the fish swims away from the icon.
	 */

	float lerpLightDim;
	bool okayToDim = false;
	float maxIntensity = 5; 
	
	// Use this for initialization
	void Start () 
	{
		light.enabled = true;
		lerpLightDim = light.intensity;
	}
	
	// Update is called once per frame
	void Update () {

		if (okayToDim) 
		{
			dimTheLight ();
		}
		else 
		{
			unDimTheLight ();
		}
	
	}

	void OnTriggerStay(Collider other)
	{
		if(other.name == "_P_Clown_Fish_Character_") okayToDim = true;
	}

	void OnTriggerExit(Collider other)
	{
		if(other.name == "_P_Clown_Fish_Character_") okayToDim = false;
	}

	void dimTheLight()
	{
		if(lerpLightDim>.1) lerpLightDim = Mathf.Lerp (lerpLightDim, 0f, 1f *Time.deltaTime);
		light.intensity = lerpLightDim;
	}

	void unDimTheLight()
	{
		lerpLightDim = Mathf.Lerp (lerpLightDim, maxIntensity, 1f *Time.deltaTime);
		light.intensity = lerpLightDim;
	}
}
