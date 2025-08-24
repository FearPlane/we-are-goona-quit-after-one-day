using System;
using System.Collections.Generic;

namespace PokemonData
{
    public class VulnerableTypes
    {
        private elementType[] pokemonType { get; set; }
        public IReadOnlyDictionary<elementType, float> vulnerableTypes;

        public VulnerableTypes(elementType[] pokemonType)
        {
            this.pokemonType = pokemonType;
            this.vulnerableTypes = CalculateVulnerabilities(pokemonType);
        }

        private Dictionary<elementType,float> CalculateVulnerabilities(elementType[] pokemonType)
        {
            Dictionary<elementType, float> _vulnerableTypes = new Dictionary<elementType, float>();

            int allElementLength = Enum.GetNames(typeof(elementType)).Length;
            float[] vulnerableValues = new float[allElementLength];
            
            for (int i = 0; i < vulnerableValues.Length; i++)
                vulnerableValues[0] = 0f;
            
            foreach (elementType type in pokemonType)
            {
                float[] chartValues = EffectivenessChart.chart[type];

                for (int i = 0; i < chartValues.Length; i++)
                {
                    vulnerableValues[i] = Math.Max(vulnerableValues[i], chartValues[i]);
                }
            }

            foreach (elementType types in Enum.GetValues(typeof(elementType)))
            {
                _vulnerableTypes.Add(types,vulnerableValues[(int)types]);
            }

            return _vulnerableTypes;
        }
    }

    public static class EffectivenessChart
    {
        /*
            2 → 2f (super effective)
            ½ → 0.5f (not very effective)
            blank → 1f (neutral)
            0 stays 0f (no effect)
        */
        
        public static Dictionary<elementType,float[]> chart { get; private set; } = new()
        {
            { elementType.Normal,  new float[] {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 0.5f, 0f, 1f, 1f, 0.5f, 1f} },
            { elementType.Fire,    new float[] {1f, 0.5f, 0.5f, 2f, 1f, 2f, 1f, 1f, 1f, 1f, 1f, 2f, 0.5f, 1f, 1f, 1f, 2f, 1f} },
            { elementType.Water,   new float[] {1f, 2f, 0.5f, 0.5f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 1f, 2f, 1f, 1f, 1f, 1f, 1f} },
            { elementType.Grass,   new float[] {1f, 0.5f, 2f, 0.5f, 1f, 1f, 1f, 0.5f, 2f, 0.5f, 1f, 0.5f, 2f, 1f, 1f, 1f, 0.5f, 1f} },
            { elementType.Electric,new float[] {1f, 1f, 2f, 0.5f, 0.5f, 1f, 1f, 1f, 0f, 2f, 1f, 1f, 1f, 1f, 1f, 1f, 0.5f, 1f} },
            { elementType.Ice,     new float[] {1f, 0.5f, 0.5f, 2f, 1f, 0.5f, 1f, 1f, 2f, 2f, 1f, 1f, 1f, 1f, 2f, 1f, 0.5f, 1f} },
            { elementType.Fighting,new float[] {2f, 1f, 1f, 1f, 1f, 2f, 1f, 0.5f, 1f, 0.5f, 0.5f, 0.5f, 2f, 0f, 1f, 2f, 2f, 0.5f} },
            { elementType.Poison,  new float[] {1f, 1f, 1f, 2f, 1f, 1f, 1f, 0.5f, 0.5f, 1f, 1f, 1f, 0.5f, 0.5f, 1f, 1f, 0f, 2f} },
            { elementType.Ground,  new float[] {1f, 2f, 1f, 0.5f, 2f, 1f, 1f, 2f, 1f, 0f, 1f, 0.5f, 2f, 1f, 1f, 1f, 2f, 1f} },
            { elementType.Flying,  new float[] {1f, 1f, 1f, 2f, 0.5f, 1f, 2f, 1f, 1f, 1f, 1f, 2f, 0.5f, 1f, 1f, 1f, 0.5f, 1f} },
            { elementType.Psychic, new float[] {1f, 1f, 1f, 1f, 1f, 1f, 2f, 2f, 1f, 1f, 0.5f, 1f, 1f, 1f, 1f, 0f, 0.5f, 1f} },
            { elementType.Bug,     new float[] {1f, 0.5f, 1f, 2f, 1f, 1f, 0.5f, 0.5f, 1f, 0.5f, 2f, 1f, 1f, 0.5f, 1f, 2f, 0.5f, 0.5f} },
            { elementType.Rock,    new float[] {1f, 2f, 1f, 1f, 1f, 2f, 0.5f, 1f, 0.5f, 2f, 1f, 2f, 1f, 1f, 1f, 1f, 0.5f, 1f} },
            { elementType.Ghost,   new float[] {0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 2f, 1f, 0.5f, 0.5f, 1f} },
            { elementType.Dragon,  new float[] {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1f, 0.5f, 0f} },
            { elementType.Dark,    new float[] {1f, 1f, 1f, 1f, 1f, 1f, 0.5f, 1f, 1f, 1f, 2f, 1f, 1f, 2f, 1f, 0.5f, 0.5f, 0.5f} },
            { elementType.Steel,   new float[] {1f, 0.5f, 0.5f, 1f, 0.5f, 2f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 1f, 0.5f, 2f} },
            { elementType.Fairy,   new float[] {1f, 0.5f, 1f, 1f, 1f, 1f, 2f, 0.5f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 2f, 0.5f, 1f} },
        };
    }
}