namespace UniversalCCG.GameFlow.States
{
	public class BootstrapState : BaseState
	{
		private const string BootSceneName = "Boot";
		private const string MenuSceneName = "Menu";
		private readonly SceneLoader _sceneLoader;

		public BootstrapState(GameStateMachine stateMachine, SceneLoader sceneLoader) : base(stateMachine)
		{
			_sceneLoader = sceneLoader;
		}

		public override void Enter()
		{
			// do some project initialization that cannot be done inside the installer
			
			_sceneLoader.Load(BootSceneName, EnterMenu);
		}

		public override void Exit()
		{
			
		}

		private void EnterMenu() => stateMachine.Enter<LoadSceneState, string, MainMenuState>(MenuSceneName);
	}
}