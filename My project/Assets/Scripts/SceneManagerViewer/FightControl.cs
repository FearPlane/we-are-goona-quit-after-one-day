using System;
using System.Collections;
using System.Collections.Generic;
using Pokemon;
using PokemonData;
using UnityEngine;

public class FightControl : MonoBehaviour
{
    private PokemonInstance player;
    private PokemonInstance enemy;
    
    private PokemonBase playerBase;
    private PokemonBase enemyBase;

    private Characters activePlayer;
    private int turnCount;
    
    private void GetPlayer(PokemonInstance _player)
    {
        this.player = _player;
        this.playerBase = _player.pokemonBase;
    }

    private void GetEnemy(PokemonInstance _enemy)
    {
        this.enemy = _enemy;
        this.enemyBase = _enemy.pokemonBase;
    }

    private void Start()
    {
        StartRound();
    }

    private void StartRound()
    {
        if (player == null || enemy == null)
        {
            Debug.Log("One of the characters didnt signed up");
            return;
        }

        Characters fastestCharacter = CheckWhoIsFasterEnemyOrPlayer();
        activePlayer = fastestCharacter;
    }

    private void ActiveBattleAction(Ability ability)
    {
        DamageContext damageContext;
        
        if (activePlayer == Characters.Player)
        {
            damageContext = new DamageContext(
                playerBase.level,
                ability.power,
                playerBase.attackPower,
                enemyBase.defensePower,
                enemyBase.vulnerableChart.vulnerableTypes[ability.elementType]);

            float takenDamage = Formulas.Damage(damageContext);

            enemyBase.hp -= takenDamage;
        }
        else
        {
            damageContext = new DamageContext(
                enemyBase.level,
                ability.power,
                enemyBase.attackPower,
                playerBase.defensePower,
                playerBase.vulnerableChart.vulnerableTypes[ability.elementType]);

            float takenDamage = Formulas.Damage(damageContext);

            playerBase.hp -= takenDamage;
        }

        turnCount++;
        if (turnCount >= 2)
            StartRound();
    }
    
    private enum Characters
    {
        Player,
        Enemy,
    }
    
    private Characters CheckWhoIsFasterEnemyOrPlayer()
    {
        return playerBase.speed > enemyBase.speed ? Characters.Player : Characters.Enemy; 
    }
}
