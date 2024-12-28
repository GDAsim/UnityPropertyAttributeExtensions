#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

[CustomPropertyDrawer(typeof(Vector3ExtraAttribute))]
public class Vector3ExtraDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.PropertyField(position, property, label);

        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.Space();
        if (EditorGUIUtilities.DrawButton("0", "Zero", EditorStyles.miniButtonLeft, Color.white, 35))
        {
            property.vector3Value = Vector3.zero;
        }
        if (EditorGUIUtilities.DrawButton("1", "One", EditorStyles.miniButtonMid, Color.white, 35))
        {
            property.vector3Value = Vector3.one;
        }
        if (EditorGUIUtilities.DrawButton("R", "Random", EditorStyles.miniButtonRight, Color.white, 35))
        {
            property.vector3Value = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), Random.Range(-100, 100));
        }
        EditorGUILayout.EndHorizontal();
    }
}
public class Vector3ExtraAttribute : PropertyAttribute { }

#endif