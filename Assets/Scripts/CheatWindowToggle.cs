using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatWindowToggle : MonoBehaviour {
	[SerializeField] private bool isWindowOpen = false;
	[SerializeField] RectTransform rectTransform;

	void Update() {
		if(Input.GetKeyDown(KeyCode.Tab)) {
			isWindowOpen = !isWindowOpen;
		}

		if(!isWindowOpen) {
			rectTransform.localPosition = new Vector2(0, 400);
		}
		else { 
			rectTransform.localPosition = new Vector2(0, 0);
		}
	}

}
