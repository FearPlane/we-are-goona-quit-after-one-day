using System.Collections.Generic;
using PokemonGame.PokemonCore.Enums;

namespace PokemonGame.Pokemon.Data
{
    public static class EffectivenessChart
    {
        /*
            2 → 2f (super effective)
            ½ → 0.5f (not very effective)
            blank → 1f (neutral)
            0 stays 0f (no effect)
        */
        
        
        private static Dictionary<ElementType,Dictionary<ElementType,float>> _chart = new()
        {
            // ATTACKING TYPE: NORMAL
            { ElementType.Normal, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 0.5f}, { ElementType.Ghost, 0.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 1.0f}
                }
            },
            
            // ATTACKING TYPE: FIRE
            { ElementType.Fire, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 0.5f}, { ElementType.Water, 0.5f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 2.0f}, { ElementType.Ice, 2.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 2.0f},
                    { ElementType.Rock, 0.5f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 0.5f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 2.0f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: WATER
            { ElementType.Water, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 2.0f}, { ElementType.Water, 0.5f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 0.5f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 2.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 2.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 0.5f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 1.0f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: ELECTRIC
            { ElementType.Electric, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 2.0f}, { ElementType.Electric, 0.5f},
                    { ElementType.Grass, 0.5f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 0.0f}, { ElementType.Flying, 2.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 0.5f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 1.0f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: GRASS
            { ElementType.Grass, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 0.5f}, { ElementType.Water, 2.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 0.5f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 0.5f},
                    { ElementType.Ground, 2.0f}, { ElementType.Flying, 0.5f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 0.5f},
                    { ElementType.Rock, 2.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 0.5f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: ICE
            { ElementType.Ice, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 0.5f}, { ElementType.Water, 0.5f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 2.0f}, { ElementType.Ice, 0.5f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 2.0f}, { ElementType.Flying, 2.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 2.0f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: FIGHTING
            { ElementType.Fighting, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 2.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 2.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 0.5f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 0.5f}, { ElementType.Psychic, 0.5f}, { ElementType.Bug, 0.5f},
                    { ElementType.Rock, 2.0f}, { ElementType.Ghost, 0.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 2.0f},
                    { ElementType.Steel, 2.0f}, { ElementType.Fairy, 0.5f}
                }
            },
                    // ATTACKING TYPE: POISON
            { ElementType.Poison, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 2.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 0.5f},
                    { ElementType.Ground, 0.5f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 0.5f}, { ElementType.Ghost, 0.5f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 0.0f}, { ElementType.Fairy, 2.0f}
                }
            },
                    // ATTACKING TYPE: GROUND
            { ElementType.Ground, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 2.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 2.0f},
                    { ElementType.Grass, 0.5f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 2.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 0.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 0.5f},
                    { ElementType.Rock, 2.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 2.0f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: FLYING
            { ElementType.Flying, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 0.5f},
                    { ElementType.Grass, 2.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 2.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 2.0f},
                    { ElementType.Rock, 0.5f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: PSYCHIC
            { ElementType.Psychic, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 2.0f}, { ElementType.Poison, 2.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 0.5f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 0.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: BUG
            { ElementType.Bug, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 0.5f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 2.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 0.5f}, { ElementType.Poison, 0.5f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 0.5f}, { ElementType.Psychic, 2.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 0.5f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 2.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 0.5f}
                }
            },
                    // ATTACKING TYPE: ROCK
            { ElementType.Rock, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 2.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 2.0f}, { ElementType.Fighting, 0.5f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 0.5f}, { ElementType.Flying, 2.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 2.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: GHOST
            { ElementType.Ghost, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 0.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 2.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 2.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 0.5f},
                    { ElementType.Steel, 1.0f}, { ElementType.Fairy, 1.0f}
                }
            },
                    // ATTACKING TYPE: DRAGON
            { ElementType.Dragon, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 2.0f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 0.0f}
                }
            },
                    // ATTACKING TYPE: DARK
            { ElementType.Dark, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 1.0f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 0.5f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 2.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 2.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 0.5f},
                    { ElementType.Steel, 1.0f}, { ElementType.Fairy, 0.5f}
                }
            },
                    // ATTACKING TYPE: STEEL
            { ElementType.Steel, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 0.5f}, { ElementType.Water, 0.5f}, { ElementType.Electric, 0.5f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 2.0f}, { ElementType.Fighting, 1.0f}, { ElementType.Poison, 1.0f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 2.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 1.0f}, { ElementType.Dark, 1.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 2.0f}
                }
            },
                    // ATTACKING TYPE: FAIRY
            { ElementType.Fairy, new Dictionary<ElementType, float>
                {
                    { ElementType.Normal, 1.0f}, { ElementType.Fire, 0.5f}, { ElementType.Water, 1.0f}, { ElementType.Electric, 1.0f},
                    { ElementType.Grass, 1.0f}, { ElementType.Ice, 1.0f}, { ElementType.Fighting, 2.0f}, { ElementType.Poison, 0.5f},
                    { ElementType.Ground, 1.0f}, { ElementType.Flying, 1.0f}, { ElementType.Psychic, 1.0f}, { ElementType.Bug, 1.0f},
                    { ElementType.Rock, 1.0f}, { ElementType.Ghost, 1.0f}, { ElementType.Dragon, 2.0f}, { ElementType.Dark, 2.0f},
                    { ElementType.Steel, 0.5f}, { ElementType.Fairy, 1.0f}
                }
            }    
        };

        public static IReadOnlyDictionary<ElementType, Dictionary<ElementType, float>> Chart => _chart;
    }
}