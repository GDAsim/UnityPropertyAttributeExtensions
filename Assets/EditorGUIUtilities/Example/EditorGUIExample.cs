using System;
using UnityEditor;
using UnityEngine;

public class EditorGUIExample : MonoBehaviour
{
    [EditorGUIExample] public int a;
}

public enum Fruits
{
    None,
    Orange,
    Potato
}

[CustomPropertyDrawer(typeof(EditorGUIExampleAttribute))]
public class EditorGUIExampleDrawer : PropertyDrawer
{
    string folderpath;
    string filepath;
    Fruits f;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        folderpath = EditorGUIUtilities.FolderLabel(nameof(folderpath), 100, folderpath);
        filepath = EditorGUIUtilities.FileLabel(nameof(filepath), 100, filepath, "txt");
        f = EditorGUIUtilities.EnumToolbar(f);
    }
}

public class EditorGUIExampleAttribute : PropertyAttribute { }