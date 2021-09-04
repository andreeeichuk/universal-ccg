using UniversalCCG.Core.CommonInterfaces;

namespace UniversalCCG.GameFlow.States
{
	public abstract class BaseExitableState : IExitableState
	{
		protected readonly GameStateMachine stateMachine;

		protected BaseExitableState(GameStateMachine stateMachine)
		{
			this.stateMachine = stateMachine;
		}
		public abstract void Exit();
	}
}