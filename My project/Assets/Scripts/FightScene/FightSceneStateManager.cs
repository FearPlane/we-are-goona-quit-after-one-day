using System;
using FightScene.State;
using UnityEngine;

namespace FightScene
{
    public class FightSceneStateManager : MonoBehaviour
    {
        private FightSceneAbstractBaseState currentState;

        private BaseState baseState = new BaseState();

        private FightState fightState = new FightState();
        private BagState bagState = new BagState();
        private PokemonState pokemonState = new PokemonState();
        private RunState runState = new RunState();

        private void Start()
        {
            currentState = baseState;
        }

        public void SetFightState() => currentState = fightState;
        public void SetBagState() => currentState = bagState;
        public void SetPokemonState() => currentState = pokemonState;
        public void SetRunState() => currentState = runState;
    }
}
