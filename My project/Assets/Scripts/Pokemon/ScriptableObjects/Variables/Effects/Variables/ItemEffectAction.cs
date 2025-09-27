namespace PokemonData.Values
{
    public enum ItemEffectAction
    {
        Steal,      // Take the target's held item and give it to the user (Thief, Covet)
        Remove,     // Knock off or destroy the target's item (Knock Off)
        Consume,    // Consume and apply the effect of the target's item (Bug Bite, Pluck)
        Give,       // Give the user’s held item to the target (Bestow)
        Swap,       // Swap items between user and target (Switcheroo, Trick)
        Fling,      // Throw the user’s held item to deal damage based on its type (Fling)
        Destroy,    // Permanently destroy target’s item without transferring it
        Restrict    // Prevent target from using its held item (Embargo, Magic Room)
    }
}