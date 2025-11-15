using PokemonGame.Pokemon;
using UnityEditor;

namespace PokemonGame.CustomEditor
{
    [UnityEditor.CustomEditor(typeof(PokemonBase))]
    public class PokemonBaseEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUI.BeginChangeCheck();
            serializedObject.Update();
            
            DrawPropertiesExcluding(serializedObject,"m_Script"); 

            PokemonBase targetObject = serializedObject.targetObject as PokemonBase;

            if(targetObject == null) return;

            targetObject.total =  targetObject.hp.value +
                                        targetObject.attackPower.value +
                                        targetObject.defensePower.value +
                                        targetObject.specialAtkPower.value +
                                        targetObject.specialDefensePower.value + 
                                        targetObject.speed.value;

            targetObject.nationalNumber = (int)targetObject.pokemonName;
            
            if (EditorGUI.EndChangeCheck())
                serializedObject.ApplyModifiedProperties();
        }
    }
}