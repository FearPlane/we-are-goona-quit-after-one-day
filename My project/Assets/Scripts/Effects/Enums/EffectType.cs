namespace PokemonGame.Effects.Enums
{
    public enum EffectType
    {
        StatusCondition,    // Inflicts a status condition on the target (Burn, Paralysis, Poison, Sleep, Freeze, Confusion, Infatuation)
        StatChange,         // Modifies a stat stage of the target or user (Atk, Def, Sp.Atk, Sp.Def, Speed, Accuracy, Evasion)
        Heal,               // Restores HP to the user or target
        StatusHeal,         // Cures status conditions on the user or target (Burn, Paralysis, Poison, Freeze)
        Protect,            // Protects the user from damage or effects for a turn
        MagicCoat,          // Reflects status moves or secondary effects back to the attacker
        Substitute,         // Creates a decoy that absorbs damage and status effects
        FieldEffect,        // Alters battlefield state, such as weather or terrain
        EntryHazard,        // Applies entry hazards to the field, damaging or affecting Pokémon switching in
        Screen,             // Reduces damage from Physical or Special moves for multiple turns
        Recoil,             // Deals recoil damage to the user based on the damage dealt
        MultiHit,           // Multi-hit moves that strike the target multiple times in one turn
        Repeat,             // Moves that repeat automatically, like Rollout or Ice Ball
        Charge,             // Moves that require a charging turn before hitting
        Priority,           // Alters execution order based on priority (e.g., Quick Attack)
        DelayNextTurn,      // Delays the effect to the next turn (e.g., Future Sight, Doom Desire)
        Switch,             // Forces the target to switch out
        Trap,               // Traps the target for multiple turns
        TypeChange,         // Changes the type of the user or target
        FormChange,         // Changes the form of the Pokémon
        ItemManipulation    // Manipulates items: swap, steal, or move-related item effects
    }
    
}