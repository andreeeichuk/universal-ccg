namespace UniversalCCG.GameFlow.States
{
	public class LoadSceneState : BasePayloadedState<string>
	{
		private readonly SceneLoader _sceneLoader;

		public LoadSceneState(GameStateMachine stateMachine, SceneLoader sceneLoader) : base(stateMachine)
		{
			_sceneLoader = sceneLoader;
		}

		public override void Enter(string sceneName) => _sceneLoader.Load(sceneName);

		public override void Exit()
		{
		}
	}
}