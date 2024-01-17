using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(GameManager)),CanEditMultipleObjects]
public class GameManagerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        GameManager manager = (GameManager)target;
        if (GUILayout.Button("AddPowerUp: Concentration"))
        {
            manager.DamagePowerUp_Concentration();
        }
        if (GUILayout.Button("AddPowerUp: Focus"))
        {
            manager.DamagePowerUp_Focus();
        }
        if (GUILayout.Button("Reset"))
        {
            manager.ResetValues();
        }
        if (GUILayout.Button("AddExperience"))
        {
            manager.AddExp(manager.ExpToAdd);
        }
    }
}
