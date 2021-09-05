using UniversalCCG.Core.CommonInterfaces;

namespace UniversalCCG.GameFlow.States
{
	public abstract class BasePayloadedStateWithFollowingState<TPayload> : BasePayloadedState<TPayload>, IPayloadedStateWithFollowingState<TPayload>
	{
		protected BasePayloadedStateWithFollowingState(GameStateMachine stateMachine) : base(stateMachine)
		{
		}

		public abstract void Enter<TNextState>(TPayload payload) where TNextState : class, IState;
	}
}