using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(TestBehaviour))]
public class TestBehaviourEditor : Editor
{
    int tomate;

    public override void OnInspectorGUI()
    {
        TestBehaviour testBehaviour = target as TestBehaviour;

        testBehaviour.propriedade =
            EditorGUILayout.IntField("Tomate",
            testBehaviour.propriedade);

        testBehaviour.volume = EditorGUILayout.Slider("Volume",
            testBehaviour.volume, 0.0f, 100.0f);

        testBehaviour.texto =
            EditorGUILayout.TextArea(testBehaviour.texto);

        EditorGUILayout.LabelField("BATATA", EditorStyles.boldLabel);

        if( GUILayout.Button("RESETAR TRASNFORM") )
        {
            testBehaviour.DoSomething();
        }
    }
}
