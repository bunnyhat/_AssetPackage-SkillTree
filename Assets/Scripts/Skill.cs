using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New SKill", menuName = "Skill Tree")]
public class Skill : ScriptableObject {
	public new string name;
	public string description;
	public Sprite skillImage;
	public int minValue, maxValue;
	public bool isLocked;
}
