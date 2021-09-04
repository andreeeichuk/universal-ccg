namespace UniversalCCG.GameFlow.States
{
	public class LoadSceneState : BasePayloadedState<string>
	{
		private const string MenuSceneName = "Menu";
		private readonly SceneLoader _sceneLoader;

		public LoadSceneState(GameStateMachine stateMachine, SceneLoader sceneLoader) : base(stateMachine)
		{
			_sceneLoader = sceneLoader;
		}

		public override void Enter(string sceneName) => _sceneLoader.Load(MenuSceneName);

		public override void Exit()
		{
		}
	}
}