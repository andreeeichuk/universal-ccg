using UniversalCCG.UI.Managers;
using UniversalCCG.UI.Pages;

namespace UniversalCCG.GameFlow.States
{
	public class MainMenuState : BaseState
	{
		private readonly SceneLoader _sceneLoader;
		private readonly MainUIManager _mainUIManager;

		public MainMenuState(GameStateMachine gameStateMachine, SceneLoader sceneLoader, MainUIManager mainUIManager) : base(gameStateMachine)
		{
			_sceneLoader = sceneLoader;
			_mainUIManager = mainUIManager;
		}

		public override void Enter()
		{
			_mainUIManager.SetCurrentPage<MainMenuScreen>();
		}

		public override void Exit()
		{
			
		}
	}
}