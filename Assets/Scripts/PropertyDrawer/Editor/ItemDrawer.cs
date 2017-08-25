using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(Item))]
public class ItemDrawer : PropertyDrawer {

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var podeUsarProp = property.FindPropertyRelative("podeUsar");
        var nameProp = property.FindPropertyRelative("nome");
        var danoProp = property.FindPropertyRelative("dano");

        Rect nameRect = new Rect(position.x, position.y,
            position.width - 32, position.height);
        EditorGUI.PropertyField(nameRect, nameProp, label);

        Rect podeUsarRect = new Rect(nameRect.xMax, position.y,
            32, position.height);
        EditorGUI.PropertyField(podeUsarRect, podeUsarProp, GUIContent.none);

    }
}
