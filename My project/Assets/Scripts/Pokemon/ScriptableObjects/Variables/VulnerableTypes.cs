using System;
using System.Collections.Generic;
using PokemonData.Values;

namespace PokemonData
{
    public class VulnerableChart
    {
        public ElementType[] pokemonType { get; set; }
        public IReadOnlyDictionary<ElementType, float> vulnerableTypes;

        public VulnerableChart(ElementType[] pokemonType)
        {
            this.pokemonType = pokemonType;
            this.vulnerableTypes = CalculateVulnerabilities(pokemonType);
        }

        private Dictionary<ElementType,float> CalculateVulnerabilities(ElementType[] pokemonType)
        {
            Dictionary<ElementType, float> _vulnerableTypes = new Dictionary<ElementType, float>();

            int allElementLength = Enum.GetNames(typeof(ElementType)).Length;
            float[] vulnerableValues = new float[allElementLength];
            
            for (int i = 0; i < vulnerableValues.Length; i++)
                vulnerableValues[0] = 0f;
            
            foreach (ElementType type in pokemonType)
            {
                float[] chartValues = EffectivenessChart.chart[type];

                for (int i = 0; i < chartValues.Length; i++)
                {
                    vulnerableValues[i] = Math.Max(vulnerableValues[i], chartValues[i]);
                }
            }

            foreach (ElementType types in Enum.GetValues(typeof(ElementType)))
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
        
        public static Dictionary<ElementType,float[]> chart { get; private set; } = new()
        {
            { ElementType.Normal,  new float[] {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 0.5f, 0f, 1f, 1f, 0.5f, 1f} },
            { ElementType.Fire,    new float[] {1f, 0.5f, 0.5f, 2f, 1f, 2f, 1f, 1f, 1f, 1f, 1f, 2f, 0.5f, 1f, 1f, 1f, 2f, 1f} },
            { ElementType.Water,   new float[] {1f, 2f, 0.5f, 0.5f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 1f, 2f, 1f, 1f, 1f, 1f, 1f} },
            { ElementType.Grass,   new float[] {1f, 0.5f, 2f, 0.5f, 1f, 1f, 1f, 0.5f, 2f, 0.5f, 1f, 0.5f, 2f, 1f, 1f, 1f, 0.5f, 1f} },
            { ElementType.Electric,new float[] {1f, 1f, 2f, 0.5f, 0.5f, 1f, 1f, 1f, 0f, 2f, 1f, 1f, 1f, 1f, 1f, 1f, 0.5f, 1f} },
            { ElementType.Ice,     new float[] {1f, 0.5f, 0.5f, 2f, 1f, 0.5f, 1f, 1f, 2f, 2f, 1f, 1f, 1f, 1f, 2f, 1f, 0.5f, 1f} },
            { ElementType.Fighting,new float[] {2f, 1f, 1f, 1f, 1f, 2f, 1f, 0.5f, 1f, 0.5f, 0.5f, 0.5f, 2f, 0f, 1f, 2f, 2f, 0.5f} },
            { ElementType.Poison,  new float[] {1f, 1f, 1f, 2f, 1f, 1f, 1f, 0.5f, 0.5f, 1f, 1f, 1f, 0.5f, 0.5f, 1f, 1f, 0f, 2f} },
            { ElementType.Ground,  new float[] {1f, 2f, 1f, 0.5f, 2f, 1f, 1f, 2f, 1f, 0f, 1f, 0.5f, 2f, 1f, 1f, 1f, 2f, 1f} },
            { ElementType.Flying,  new float[] {1f, 1f, 1f, 2f, 0.5f, 1f, 2f, 1f, 1f, 1f, 1f, 2f, 0.5f, 1f, 1f, 1f, 0.5f, 1f} },
            { ElementType.Psychic, new float[] {1f, 1f, 1f, 1f, 1f, 1f, 2f, 2f, 1f, 1f, 0.5f, 1f, 1f, 1f, 1f, 0f, 0.5f, 1f} },
            { ElementType.Bug,     new float[] {1f, 0.5f, 1f, 2f, 1f, 1f, 0.5f, 0.5f, 1f, 0.5f, 2f, 1f, 1f, 0.5f, 1f, 2f, 0.5f, 0.5f} },
            { ElementType.Rock,    new float[] {1f, 2f, 1f, 1f, 1f, 2f, 0.5f, 1f, 0.5f, 2f, 1f, 2f, 1f, 1f, 1f, 1f, 0.5f, 1f} },
            { ElementType.Ghost,   new float[] {0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 2f, 1f, 0.5f, 0.5f, 1f} },
            { ElementType.Dragon,  new float[] {1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1f, 0.5f, 0f} },
            { ElementType.Dark,    new float[] {1f, 1f, 1f, 1f, 1f, 1f, 0.5f, 1f, 1f, 1f, 2f, 1f, 1f, 2f, 1f, 0.5f, 0.5f, 0.5f} },
            { ElementType.Steel,   new float[] {1f, 0.5f, 0.5f, 1f, 0.5f, 2f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 1f, 1f, 1f, 0.5f, 2f} },
            { ElementType.Fairy,   new float[] {1f, 0.5f, 1f, 1f, 1f, 1f, 2f, 0.5f, 1f, 1f, 1f, 1f, 1f, 1f, 2f, 2f, 0.5f, 1f} },
        };
    }
}