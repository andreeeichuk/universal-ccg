using UniversalCCG.Core.CommonInterfaces;

namespace UniversalCCG.GameFlow.States
{
	public abstract class BaseState : BaseExitableState, IState
	{
		protected BaseState(GameStateMachine stateMachine) : base(stateMachine)
		{
		}
		public abstract void Enter();
	}
}