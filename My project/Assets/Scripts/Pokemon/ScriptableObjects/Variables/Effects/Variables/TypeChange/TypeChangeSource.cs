namespace PokemonData.Values
{
    public enum TypeChangeSource
    {
        Soak,               // Move: Changes target's type to Water
        ForestsCurse,       // Move: Adds Grass type to target (target retains original type(s))
        TrickOrTreat,       // Move: Adds Ghost type to target (target retains original type(s))
        Conversion,         // Move: Changes user type to match one of its moves (the chosen move's type)
        Conversion2,        // Move: Changes user type to a type resistant to opponent's type
        Camouflage,         // Move: Changes user type based on terrain:
                        //    Normal Terrain -> Normal, Grass Terrain -> Grass, Water Terrain -> Water, etc.
        Protean,            // Ability: Changes user type to match the move used (e.g., Fire move → Fire type)
        Libero,             // Ability: Same as Protean
        ColorChange,        // Ability: Changes user type to the type of the move that hits it (e.g., Electric hit → Electric type)
        ArceusPlate,        // Item: Changes Arceus type to match Plate held (e.g., Flame Plate → Fire type)
        SilvallyMemory,     // Item: Changes Silvally type to match Memory held (e.g., Shock Memory → Electric type)
        Gem,                // Item: Temporarily boosts a move of a specific type (does not permanently change type)
        SoothingMist,       // Move: Hypothetical or custom example; could change type or apply effect
        Aerilate,           // Ability: Converts Normal-type moves to Flying type
        Pixilate,           // Ability: Converts Normal-type moves to Fairy type
        Refrigerate,        // Ability: Converts Normal-type moves to Ice type
        Galvanize,          // Ability: Converts Normal-type moves to Electric type
        ProteanMove,        // Generic: Covers moves that trigger Protean effect (type matches move used)
        WeatherBall,        // Move: Changes type based on weather:
                        //    Sunny Day -> Fire, Rain -> Water, Sandstorm -> Rock, Hail -> Ice, Clear -> Normal
        Judgment,           // Move: Changes type based on held Plate (e.g., Flame Plate -> Fire, Splash Plate -> Water)
        NaturalGift         // Move: Changes type based on held Berry (e.g., Cheri Berry -> Fire, Oran Berry -> Normal)
    }

}