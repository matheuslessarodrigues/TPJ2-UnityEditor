using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Av1))]
public sealed class Av1Editor : Editor
{
    public override void OnInspectorGUI()
    {
        var av1 = target as Av1;
        Undo.RecordObject(av1,"AV1");

        foreach( var e in av1.entries )
        {
            e.value = EditorGUILayout.IntField( e.key, e.value);
        }
    }
}
