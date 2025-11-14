using PokemonGame.Effects;
using PokemonGame.Effects.Enums;
using PokemonGame.Move;
using PokemonGame.PokemonCore.Enums;
using UnityEditor;

namespace PokemonGame.CustomEditor
{
    [UnityEditor.CustomEditor(typeof(MoveBase))]
    public class MoveBaseEditor : Editor
    {
        private SerializedProperty effectsProperty;
        private EffectsData effectsRef;
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            serializedObject.Update();
            
            MoveBase targetObject = serializedObject.targetObject as MoveBase;
            if (targetObject == null) return;

            EditorGUILayout.LabelField("Action Type",targetObject.actionType.ToString(),EditorStyles.boldLabel);
            
            string[] excludingProperties = {"m_Script",nameof(targetObject.actionType),nameof(targetObject.effects)}; 
            DrawPropertiesExcluding(serializedObject, excludingProperties); //print effects the exact name inside the variable ability value type
            
            EditorGUILayout.Space();
            
            effectsProperty = serializedObject.FindProperty(nameof(targetObject.effects));

            if (targetObject.actionCategory == ActionCategory.Status && effectsProperty != null)
            {
                effectsRef = targetObject.effects;
                EditorGUILayout.PropertyField(effectsProperty.FindPropertyRelative(nameof(effectsRef.type)));

                DrawFields();
            }
            
            if (!EditorGUI.EndChangeCheck()) return;
            
            serializedObject.ApplyModifiedProperties();
            
            effectsRef.Stages = effectsRef._stages;
            effectsRef.Priority = effectsRef._priority;
            effectsRef.Value = effectsRef._value;
        }

        private void DrawFields()
        {
            DrawEffectsFieldsWithStates(EffectType.StatusCondition, nameof(effectsRef.status));
            DrawEffectsFieldsWithStates(EffectType.StatChange, nameof(effectsRef.battleStat));
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

