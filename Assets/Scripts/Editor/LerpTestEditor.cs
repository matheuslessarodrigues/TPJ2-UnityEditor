using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LerpTest))]
public sealed class LerpTestEditor : Editor
{
    // dontpad.com/TPJ2
    public override void OnInspectorGUI()
	{
        LerpTest lerpTest = target as LerpTest;

        lerpTest.min = EditorGUILayout.FloatField("Min", lerpTest.min);
        lerpTest.max = EditorGUILayout.FloatField("Max", lerpTest.max);
        lerpTest.t = EditorGUILayout.FloatField("T", lerpTest.t);

        float x = Mathf.Lerp(lerpTest.min, lerpTest.max, lerpTest.t);
	}
}
