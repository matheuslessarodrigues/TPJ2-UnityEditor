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
        //base.OnInspectorGUI();

        TestBehaviour testBehaviour = target as TestBehaviour;

        //testBehaviour.array
        for( int i = 0; i < testBehaviour.list.Count; i++)
        {
            testBehaviour.list[i] =
                EditorGUILayout.IntField("Array " + i,
                testBehaviour.list[i]);
        }
        

        /*
        testBehaviour.propriedade =
            EditorGUILayout.IntField("Tomate",
            testBehaviour.propriedade);

        testBehaviour.volume = EditorGUILayout.Slider("Volume",
            testBehaviour.volume, 0.0f, 100.0f);

        testBehaviour.texto =
            EditorGUILayout.TextArea(testBehaviour.texto);

        testBehaviour.lookAtTarget =
            EditorGUILayout.ObjectField("Target",
            testBehaviour.lookAtTarget, typeof(Transform),
            true) as Transform;
            */
        EditorGUILayout.LabelField("BATATA", EditorStyles.boldLabel);

        if( GUILayout.Button("RESETAR TRASNFORM") )
        {
            testBehaviour.DoSomething();
        }
    }
}
