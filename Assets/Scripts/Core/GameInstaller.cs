using UniversalCCG.Core.CommonInterfaces;
using UniversalCCG.GameFlow;
using Zenject;

namespace UniversalCCG.Core
{
	public class GameInstaller : MonoInstaller
	{
		public override void InstallBindings()
		{
			Container.Bind<Game>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
			Container.Bind<GameStateMachine>().AsSingle();
			Container.Bind<SceneLoader>().AsSingle();
			Container.Bind<ICoroutineRunner>().To<CoroutineRunner>().FromNewComponentOnNewGameObject().AsSingle().NonLazy();
		}
	}
}