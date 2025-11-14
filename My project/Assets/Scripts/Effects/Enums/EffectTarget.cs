namespace PokemonGame.Effects.Enums
{
    public enum EffectTarget
    {
        Self,               // The Pokémon using the move (e.g., Swords Dance, Recover, Calm Mind)
        Opponent,           // The Pokémon the move is hitting (e.g., Growl, Thunderbolt, Rock Smash)
        AllOpponents,       // All opposing Pokémon in battle (double/triple battles) (e.g., Surf, Earthquake)
        AllAllies,          // All allies of the user (e.g., Helping Hand, Tailwind)
        AllEnemies,         // All Pokémon on the opposing side (same as AllOpponents) (e.g., Heat Wave)
        AllPokemon,         // Everyone on the battlefield (e.g., Hail, Sandstorm, Explosion)
        Field,              // Applies to the battlefield itself (e.g., Stealth Rock, Sunny Day, Reflect, Light Screen)
        RandomOpponent,     // Random target among opponents (e.g., Rock Blast, Fury Swipes)
        AdjacentOpponent,   // Only adjacent foes in multi-battles (e.g., Brick Break, Poison Jab)
        AdjacentAlly        // Only adjacent allies (e.g., Helping Hand in doubles)
    }
}