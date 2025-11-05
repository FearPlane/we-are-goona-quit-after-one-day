using System;
using PokemonData;
using PokemonData.Values;
using Unity.VisualScripting;
using UnityEngine;
using UnityEditor;

namespace Attribute
{
    [CustomEditor(typeof(AbilityData))]
    public class AbilityDataShowIfEditor : Editor
    {
        private SerializedProperty effectsProperty;
        private Effects effectsRef;
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            serializedObject.Update();
            
            AbilityData targetObject = serializedObject.targetObject as AbilityData;
            if (targetObject == null) return;

            EditorGUILayout.LabelField("Action Type",targetObject.actionType.ToString(),EditorStyles.boldLabel);
            EditorGUILayout.LabelField("Action Category",targetObject.actionCategory.ToString(),EditorStyles.boldLabel);
            
            string[] excludingProperties = {"m_Script",nameof(targetObject.actionType),nameof(targetObject.actionCategory),nameof(targetObject.effects)};
            DrawPropertiesExcluding(serializedObject,excludingProperties);
            
            EditorGUILayout.Space();
            
            effectsProperty = serializedObject.FindProperty(nameof(targetObject.effects));
            if (effectsProperty == null) return;

            
            effectsRef = targetObject.effects;
            EditorGUILayout.LabelField("Effects");
            EditorGUILayout.PropertyField(effectsProperty.FindPropertyRelative(nameof(effectsRef.type)));

            DrawFields();
            
            
            if (!EditorGUI.EndChangeCheck()) return;
            
            serializedObject.ApplyModifiedProperties();
            
            effectsRef.Stages = effectsRef._stages;
            effectsRef.Priority = effectsRef._priority;
            effectsRef.Value = effectsRef.Value;
        }

        private void DrawFields()
        {
            DrawEffectsFieldsWithStates(EffectType.StatusCondition, nameof(effectsRef.status));
            DrawEffectsFieldsWithStates(EffectType.StatChange, nameof(effectsRef.stat));
            DrawEffectsFieldsWithStates(EffectType.StatChange, nameof(effectsRef._stages));
            
            DrawEffectsFields(nameof(effectsRef.chance));
            DrawEffectsFields(nameof(effectsRef.target));
            DrawEffectsFields(nameof(effectsRef._value));
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

