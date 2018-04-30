using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SkillPointGenerator))]
public class CustomSkillTreeEditor : Editor {

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();
        SkillPointGenerator skillPointGenerator = (SkillPointGenerator)target;

        GUILayout.BeginHorizontal();
        //Generates a skill point with the given values
        if(GUILayout.Button("Generate Skill")) {
            skillPointGenerator.GenerateSkill();
        }
        //Resets values back to null
        if(GUILayout.Button("Reset Values")) {
            skillPointGenerator.name = "";
            skillPointGenerator.description = "";
            skillPointGenerator.skillImage = null;
            skillPointGenerator.minValue = 0;
            skillPointGenerator.maxValue = 0;
            skillPointGenerator.isLocked = false;
        }
        GUILayout.EndHorizontal();



    }
	
}
