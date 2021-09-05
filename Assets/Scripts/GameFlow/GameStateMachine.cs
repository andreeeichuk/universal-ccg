using System;
using System.Collections.Generic;
using UniversalCCG.Core.CommonInterfaces;
using UniversalCCG.GameFlow.States;
using UniversalCCG.UI.Managers;

namespace UniversalCCG.GameFlow
{
	public class GameStateMachine : IStateMachine
	{
		private readonly Dictionary<Type, IExitableState> _states;
		private IExitableState _currentState;

		public GameStateMachine(SceneLoader sceneLoader, MainUIManager mainUIManager)
		{
			_states = new Dictionary<Type, IExitableState>
			{
				[typeof(BootstrapState)] = new BootstrapState(this, sceneLoader),
				[typeof(LoadSceneState)] = new LoadSceneState(this, sceneLoader, mainUIManager),
				[typeof(MainMenuState)] = new MainMenuState(this, sceneLoader, mainUIManager)
			};
		}
		
		public void Enter<TState>() where TState : class, IState
		{
			IState state = ChangeState<TState>();
			state.Enter();
		}

		public void Enter<TState, TPayload>(TPayload payload) where TState : class, IPayloadedState<TPayload>
		{
			TState state = ChangeState<TState>();
			state.Enter(payload);
		}
		
		public void Enter<TState, TPayload, TNextState>(TPayload payload) 
			where TState : class, IPayloadedStateWithFollowingState<TPayload> 
			where TNextState : class, IState
		{
			TState state = ChangeState<TState>();
			state.Enter<TNextState>(payload);
		}

		private TState ChangeState<TState>() where TState : class, IExitableState
		{
			_currentState?.Exit();
			TState state = GetState<TState>();
			_currentState = state;
			return state;
		}

		private TState GetState<TState>() where TState : class, IExitableState
		{
			return _states[typeof(TState)] as TState;
		}
	}
}