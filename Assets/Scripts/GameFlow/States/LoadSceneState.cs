using UniversalCCG.Core.CommonInterfaces;
using UniversalCCG.UI.Managers;
using UniversalCCG.UI.Pages;

namespace UniversalCCG.GameFlow.States
{
	public class LoadSceneState : BasePayloadedStateWithFollowingState<string>
	{
		private readonly SceneLoader _sceneLoader;
		private readonly MainUIManager _mainUIManager;

		public LoadSceneState(GameStateMachine stateMachine, SceneLoader sceneLoader, MainUIManager mainUIManager) : base(stateMachine)
		{
			_sceneLoader = sceneLoader;
			_mainUIManager = mainUIManager;
		}

		public override void Enter(string sceneName)
		{
			_mainUIManager.SetCurrentPage<LoadingScreen>();
			_sceneLoader.Load(sceneName);
		}

		public override void Enter<TNextState>(string sceneName)
		{
			_mainUIManager.SetCurrentPage<LoadingScreen>();
			_sceneLoader.Load(sceneName, EnterNextState<TNextState>);
		}

		private void EnterNextState<TState>() where TState : class, IState
		{
			stateMachine.Enter<TState>();
		}

		public override void Exit()
		{
		}
	}
}