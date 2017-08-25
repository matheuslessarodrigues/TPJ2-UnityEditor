using UnityEditor;
using UnityEngine;

//[CustomEditor(typeof(AnotherTestBehaviour))]
public class AnotherTestBehaviourEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();

        AnotherTestBehaviour behaviour = target as AnotherTestBehaviour;

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Item1");
        behaviour.item1.podeUsar = EditorGUILayout.Toggle(behaviour.item1.podeUsar);
        behaviour.item1.nome = EditorGUILayout.TextField(behaviour.item1.nome);
        behaviour.item1.dano = EditorGUILayout.IntField(behaviour.item1.dano);
        EditorGUILayout.EndHorizontal();

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.LabelField("Item2");
        behaviour.item2.podeUsar = EditorGUILayout.Toggle(behaviour.item2.podeUsar);
        behaviour.item2.nome = EditorGUILayout.TextField(behaviour.item2.nome);
        behaviour.item2.dano = EditorGUILayout.IntField(behaviour.item2.dano);
        EditorGUILayout.EndHorizontal();
    }
}
