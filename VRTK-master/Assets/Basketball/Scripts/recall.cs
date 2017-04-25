using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recall : MonoBehaviour {

	public GameObject Player;
	public bool clicked = false;
	private Vector offset;

	// Use this for initialization
	void Start () {
		clicked = GetComponent<VRTK_ControllerEvents> ().GripPressed;
	}
	
	// Update is called once per frame
	void Update () {
		
		clicked = GetComponent<VRTK_ControllerEvents>().gripPressed;

		if (clicked) {
			SetPositionAndRotation (offset, 0);
		}
			
	}
}
