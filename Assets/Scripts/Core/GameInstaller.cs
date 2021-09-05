using UniversalCCG.Core.CommonInterfaces;
using UniversalCCG.GameFlow;
using UniversalCCG.UI.Managers;
using Zenject;

namespace UniversalCCG.Core
{
	public class GameInstaller : MonoInstaller
	{
		private const string MainUIPrefabPath = "UI/MainUI";

		public override void InstallBindings()
		{
			Container.Bind<Game>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
			Container.Bind<MainUIManager>().FromComponentInNewPrefabResource(MainUIPrefabPath).AsSingle().NonLazy();
			Container.Bind<GameStateMachine>().AsSingle();
			Container.Bind<SceneLoader>().AsSingle();
			Container.Bind<ICoroutineRunner>().To<CoroutineRunner>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
		}
	}
}