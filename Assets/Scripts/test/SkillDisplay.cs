using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillDisplay : MonoBehaviour {
	public Skill skill;
	public Sprite lockedSprite, unlockedSprite;
	public Skill[] nextSkills;

	[SerializeField] private Text nameText;
	[SerializeField] private Text descriptionText;	
	[SerializeField] private Image artwork;
	[SerializeField] private Text minMaxValue;
	[SerializeField] private bool isLocked;
	[SerializeField] private Image lockImage;

	Button m_skillButton;

	void Awake() {
		m_skillButton = GetComponent<Button>();
	}

	void Update() {
		artwork.sprite = skill.skillImage;
		minMaxValue.text = skill.minValue + "/" + skill.maxValue;
		isLocked = skill.isLocked;

		if(isLocked) {
			lockImage.sprite = lockedSprite;
			m_skillButton.interactable = false;
		} else {
			lockImage.sprite = unlockedSprite;
			m_skillButton.interactable = true;
		}

		if(skill.minValue >= 1) {
			for(int i = 0; i < nextSkills.Length; i++) {
				nextSkills[i].isLocked = false;
			}
		}
	}

	public void OnClick() {
		nameText.text = skill.name;
		descriptionText.text = skill.description;			
	}
	
}
