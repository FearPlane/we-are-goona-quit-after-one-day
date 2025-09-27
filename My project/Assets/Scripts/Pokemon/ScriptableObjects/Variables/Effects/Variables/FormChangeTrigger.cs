namespace PokemonData.Values
{
    public enum FormChangeTrigger
    {
        Manual,     // Triggered directly by a move (Relic Song -> Meloetta)
        Move,       // Triggered when using a move (King’s Shield -> Aegislash Shield Form)
        Ability,    // Triggered by ability activation (Zen Mode -> Darmanitan)
        Weather,    // Triggered by weather effects (Castform, Cherrim)
        Item,       // Triggered by holding/using an item (Giratina with Griseous Orb)
        Terrain,    // Triggered by battlefield terrain (e.g., hypothetical cases)
        HP,         // Triggered when HP is above/below a threshold (Zen Mode)
        Entry,      // Triggered when entering battle (Battle Bond -> Greninja)
        Special     // Unique/special-case trigger (Arceus with Plates, Silvally with Memories)
    }
}