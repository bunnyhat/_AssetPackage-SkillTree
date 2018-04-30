using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillsManager : MonoBehaviour {

	public int skillPoints, spentPoints;
	public Text skillPointsText;
	public Button purchaseButton;
	public Skill[] skills;
	public Text skillName;

	void Awake() {
		skillPoints = 5;
	}

	void Update() {
		skillPointsText.text = "Skill Points: " + skillPoints;
	}

	public void PurchaseSkill() {
		if(skillName.text != "" && skillPoints >= 1) {
			for(int i = 0; i < skills.Length; i++) {
				if(skills[i].name == skillName.text && !skills[i].isLocked && skills[i].minValue < skills[i].maxValue) {
					skills[i].minValue += 1;
					skillPoints -= 1;
					spentPoints += 1;
					Debug.Log(skillName.text + " purchased!");
				}
			}
		}
	}

	public void ResetSkills() {
		for(int i = 0; i < skills.Length; i++) {
			if(skills[i].minValue >= 1) {
				skills[i].minValue = 0;
				skillPoints = skillPoints + spentPoints;
				spentPoints = 0;
				skills[0].isLocked = false;
			}
		}
		for(int i = 1; i < skills.Length; i++) {
			skills[i].isLocked = true;
		}
	}

}
