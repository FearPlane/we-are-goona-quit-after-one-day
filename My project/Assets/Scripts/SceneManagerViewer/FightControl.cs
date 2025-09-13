using System;
using System.Collections;
using System.Collections.Generic;
using Pokemon;
using PokemonData;
using UnityEngine;



public class FightControl : MonoBehaviour
{
    private enum Characters
    {
        Player,
        Enemy,
    }
    
    private bool isPlayerTurn;
    private int turnCount;

    private PokemonInstance player;
    private PokemonInstance enemy;
    
    private PokemonBase playerBase;
    private PokemonBase enemyBase;

    public void SetPlayer(PokemonInstance _player)
    {
        this.player = _player;
        this.playerBase = _player.pokemonBase;
    }

    public void SetEnemy(PokemonInstance _enemy)
    {
        this.enemy = _enemy;
        this.enemyBase = _enemy.pokemonBase;
    }
    
    private Characters GetFastestParticipate()
    {
        return playerBase.speed > enemyBase.speed ? Characters.Player : Characters.Enemy; 
    }

    private void StartRound()
    {
        if (player.pokemonBase == null || enemy.pokemonBase == null)
        {
            Debug.Log("One of the characters didnt signed up");
            Debug.Log("playerInfo" + player);
            Debug.Log("enemyInfo" + enemy);
            return;
        }

        Characters fastestParticipate = GetFastestParticipate();
        isPlayerTurn = fastestParticipate == Characters.Player;
    }

    private void Turn(Ability ability)
    {
        PokemonBase attacker = isPlayerTurn ? playerBase : enemyBase;
        PokemonBase target = isPlayerTurn ? enemyBase : playerBase;
        
        target.vulnerableChart = new VulnerableChart(target.type);
            
        DamageContext enemyDamageContext = new DamageContext(
            attacker.level,
            ability.power,
            attacker.attackPower,
            target.defensePower,
            target.vulnerableChart.vulnerableTypes[ability.elementType]);

        float damage = Formulas.Damage(enemyDamageContext);
        target.hp -= damage;
        
        turnCount++;
        isPlayerTurn = !isPlayerTurn;
        
        if (turnCount < 2) return;
        turnCount = 0;
        StartRound();
    }
}
