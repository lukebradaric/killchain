﻿using KillChain.Core.StateMachine;
using UnityEngine;

namespace KillChain.Player.States
{
    public class PlayerChainStateMachine : StateMachine
    {
        // TODO : Improve how references are passed
        public Player _player;

        [Space]
        [Header("States")]
        [SerializeReference] public PlayerChainState IdleState;
        [SerializeReference] public PlayerChainState ThrowDashState;
        [SerializeReference] public PlayerChainState ThrowPullState;
        [SerializeReference] public PlayerChainState DashState;
        [SerializeReference] public PlayerChainState PullState;

        // TOOD : Improve how debugging is done with state machines
        public string currentState;
        private void Update()
        {
            currentState = CurrentState.GetType().Name;
        }

        private void Start()
        {
            ChangeState(IdleState);
        }


        protected override void OnStateChanging(State newState)
        {
            ((PlayerChainState)newState).SetPlayer(_player);
        }
    }
}
