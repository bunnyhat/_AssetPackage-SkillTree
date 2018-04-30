using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatWindowToggle : MonoBehaviour {
	[SerializeField] private bool isWindowOpen = false;
	[SerializeField] RectTransform rectTransform;
	[SerializeField] InputField cheatText;
	[SerializeField] Image background;
	
	[SerializeField] SkillsManager skillsManager;


	void Update() {
		if(Input.GetKeyDown(KeyCode.Tab)) {
			isWindowOpen = !isWindowOpen;
		}

		if(!isWindowOpen) {
			rectTransform.localPosition = new Vector2(0, 400);
			cheatText.text = "";
			background.enabled = false;

		} else { 
			rectTransform.localPosition = new Vector2(0, 0);
			background.enabled = true;
		}

		if(cheatText.text != "" && Input.GetKeyDown(KeyCode.KeypadEnter)) {
			int points = int.Parse(cheatText.text);
			skillsManager.skillPoints += points;
			if(points <= -1) {
				skillsManager.skillPoints = 0;
			}
			cheatText.text = "";
		}
	}

}
