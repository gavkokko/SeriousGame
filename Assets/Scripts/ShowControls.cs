using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowControls : MonoBehaviour {
	[SerializeField]
	private GameObject ControlsPane;
	[SerializeField]
	private Button myButton;

	void Start () {
		ControlsPane.SetActive (false);

		Button btn = myButton.GetComponent<Button> ();
		btn.onClick.AddListener (PressControls);
	}
	
	void PressControls(){
		ControlsPane.SetActive (true);
	}
}
