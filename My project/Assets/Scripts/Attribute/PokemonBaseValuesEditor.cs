using PokemonData;
using UnityEditor;
using UnityEngine;

namespace Attribute
{
    [CustomEditor(typeof(PokemonBase))]
    public class PokemonBaseValuesEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            DrawDefaultInspector();

            PokemonBase targetObject = serializedObject.targetObject as PokemonBase;

            if(targetObject == null) return;
            
            targetObject.total =  (int)(targetObject.hp +
                                        targetObject.attackPower +
                                        targetObject.defensePower +
                                        targetObject.specialAtkPower +
                                        targetObject.specialDefensePower + 
                                        targetObject.speed);

            targetObject.nationalNumber = (int)targetObject.pokemonName;
            
            if (!EditorGUI.EndChangeCheck())
                EditorUtility.SetDirty(targetObject);
        }
    }
}