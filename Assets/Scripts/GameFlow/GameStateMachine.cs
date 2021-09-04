using System;
using System.Collections.Generic;
using UniversalCCG.Core.CommonInterfaces;
using UniversalCCG.GameFlow.States;

namespace UniversalCCG.GameFlow
{
	public class GameStateMachine : IStateMachine
	{
		private readonly Dictionary<Type, IExitableState> _states;
		private IExitableState _currentState;

		public GameStateMachine(SceneLoader sceneLoader)
		{
			_states = new Dictionary<Type, IExitableState>
			{
				[typeof(BootstrapState)] = new BootstrapState(this, sceneLoader),
				[typeof(LoadSceneState)] = new LoadSceneState(this, sceneLoader)
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