using UnityEngine;
using UniversalCCG.GameFlow;
using UniversalCCG.GameFlow.States;
using Zenject;

namespace UniversalCCG.Core
{
	public class Game : MonoBehaviour
	{
		private GameStateMachine _stateMachine;

		[Inject]
		private void Construct(GameStateMachine stateMachine)
		{
			_stateMachine = stateMachine;
		}

		private void Start()
		{
			_stateMachine.Enter<BootstrapState>();
		}
	}
}