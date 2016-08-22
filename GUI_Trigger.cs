using UnityEngine;
using System.Collections;

public class GUI_Trigger : MonoBehaviour {

	/*
	 *  This script checks if the game object that enters the trigger zone of an icon 
	 *  is the player controlled fish, and if so makes a call to the GUI_Manager script 
	 *  in order to turn on the gui functionality.
	 */

	private float triggerTimer;
	private float timerLimit = 0.0f;
	private bool activated = false;

	public GUI_Manager gui;
	private KnowledgeDrop kDrop;

	bool playAudio = true;


	void Start ()
	{

	}

	void update()
	{

	}

	/*
	 *  When the icons are triggered, check if the object to cause the trigger is the player fish.
	 *  If it is the player fish, and the gui is not activated, begin activation of visual and audio cues.
	 */
	void OnTriggerStay(Collider other)
	{
		if (!activated && other.name == "_P_Clown_Fish_Character_") {
			triggerTimer += Time.deltaTime;
			

			// activate after timerLimit seconds
			if (triggerTimer > timerLimit) 
			{
				gui.TurnOnGUI(this.gameObject);

				if (playAudio) 
				{
					if(!audio.isPlaying)
					{
						audio.Play();
						playAudio = false; //signal that it is not okay for audio to continuously repeat
					}
				}
			}
		}
	}

	void OnTriggerExit()
	{
		triggerTimer = 0.0f;
		gui.TurnOffGUI();
		playAudio = true; //signal that it's okay to play audio
	}
}
