using System;
using PokemonData;
using PokemonData.Values;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;

namespace Attribute
{
    [CustomEditor(typeof(Ability))]
    public class AbilityShowIfEditor : Editor
    {
        bool showFoldoutContent = true;

        private SerializedProperty effectsProperty;
        private Effects effectsRef;
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            serializedObject.Update();
            
            Ability targetObject = serializedObject.targetObject as Ability;
            if (targetObject == null) return;

            DrawPropertiesExcluding(serializedObject, "m_Script",nameof(targetObject.effects)); //print effects the exact name inside the variable ability value type
            
            effectsProperty = serializedObject.FindProperty(nameof(targetObject.effects));
            if (effectsProperty == null) return;

            effectsRef = targetObject.effects;
            showFoldoutContent = EditorGUILayout.Foldout(showFoldoutContent, effectsRef.GetType().Name);

            if (!showFoldoutContent) return;

            EditorGUILayout.PropertyField(effectsProperty.FindPropertyRelative(nameof(effectsRef.type)));

            DrawFields();

            if (!EditorGUI.EndChangeCheck()) return;
            
            serializedObject.ApplyModifiedProperties();
            
            effectsRef.Stages = effectsRef._stages;
            effectsRef.Priority = effectsRef._priority;
        }

        private void DrawFields()
        {
            DrawEffectsFieldsWithStates(EffectType.StatusCondition, nameof(effectsRef.status));
            DrawEffectsFieldsWithStates(EffectType.StatChange, nameof(effectsRef.stat));
            DrawEffectsFieldsWithStates(EffectType.StatChange, nameof(effectsRef._stages));
            
            DrawEffectsFields(nameof(effectsRef.chance));
            DrawEffectsFields(nameof(effectsRef.target));
            DrawEffectsFields(nameof(effectsRef.value));
            DrawEffectsFields(nameof(effectsRef.duration));
            DrawEffectsFields(nameof(effectsRef._priority));
            DrawEffectsFields(nameof(effectsRef.repeats));
            DrawEffectsFields(nameof(effectsRef.fieldEffectType));
            DrawEffectsFields(nameof(effectsRef.item));
            
            DrawEffectsFieldsWithStates(EffectType.FormChange,nameof(effectsRef.form));
            DrawEffectsFieldsWithStates(EffectType.TypeChange,nameof(effectsRef.typeChange));
        }

        private void DrawEffectsFieldsWithStates(EffectType stateEffectType,string fieldToDraw)
        {
            if(effectsRef != null && effectsRef.type == stateEffectType)
                DrawPropertyField(effectsProperty.FindPropertyRelative(fieldToDraw));
        }
        
        private void DrawEffectsFields(string fieldToDraw)
        {
            DrawPropertyField(effectsProperty.FindPropertyRelative(fieldToDraw));
        }

        private void DrawPropertyField(SerializedProperty serializedProperty)
        {
            EditorGUILayout.PropertyField(serializedProperty);
        }
    }
}

