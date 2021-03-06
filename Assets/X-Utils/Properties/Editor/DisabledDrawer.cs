﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;

[CustomPropertyDrawer(typeof(DisabledAttribute))]
class DisabledDrawer : PropertyDrawer
{

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        
        
        //get the attribute data
        //DisabledAttribute DisabledAtt = (DisabledAttribute)attribute;

        //Enable/disable the property
        bool wasEnabled = GUI.enabled;
        GUI.enabled = false;


        EditorGUI.PropertyField(position, property, label, true);

        //Ensure that the next property that is being drawn uses the correct settings
        GUI.enabled = wasEnabled;
        
    }



    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        ///return -EditorGUIUtility.standardVerticalSpacing;
        return EditorGUI.GetPropertyHeight(property, label);
    }


}