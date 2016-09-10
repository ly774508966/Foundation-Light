using MVVM;
using UnityEditor;
using UnityEngine;

namespace MVVM
{

    [CustomPropertyDrawer(typeof(SourceBinding))]
    public class SourceBindingDrawer : PropertyDrawer
    {
        // Draw the property inside the given rect
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {

            /*
             * ************************************************************
             *                                               Binding Source                                              
             * Target Label           [>] Source [X][Find] (Remove, Lookup) 
             *                           null |   WARNING BINDING IS FUCKED 
             * ************************************************************
             */



            var control = property.objectReferenceValue;




            SerializedProperty member = property.FindPropertyRelative("Member");


            //if (source.objectReferenceValue == null)
            //{
            //    //Go find the fucker
            //}









            EditorGUI.BeginProperty(position, label, property);

            // Draw label
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.PropertyField(new Rect(position.x - 120, position.y + 20, position.width + 120, 20), member);

            EditorGUI.EndProperty();
        }
    }

    [CustomPropertyDrawer(typeof(MemberBinding))]
    public class MemberBindingDrawer : PropertyDrawer
    {
        // Draw the property inside the given rect
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {

            /*
             * ************************************************************
             *                             BINDING TITLE / CONTROL PROPERTY                                              
             * Target Label           [>] Source [X][Find] (Remove, Lookup)
             * Member Label         Dropdown if model & correct | TextField       
             *                      null |   WARNING BINDING IS FUCKED 
             * ************************************************************
             */



            var control = property.objectReferenceValue;




            SerializedProperty member = property.FindPropertyRelative("Member");


            //if (source.objectReferenceValue == null)
            //{
            //    //Go find the fucker
            //}









            EditorGUI.BeginProperty(position, label, property);

            // Draw label
            position = EditorGUI.PrefixLabel(position, label);

            EditorGUI.PropertyField(new Rect(position.x - 120, position.y + 20, position.width + 120, 20), member);

            EditorGUI.EndProperty();
        }
    }
}