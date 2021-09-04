using UniversalCCG.Core.CommonInterfaces;

namespace UniversalCCG.GameFlow.States
{
	public abstract class BasePayloadedState<TPayload> : BaseExitableState, IPayloadedState<TPayload>
	{
		protected BasePayloadedState(GameStateMachine stateMachine) : base(stateMachine)
		{
		}
		public abstract void Enter(TPayload payload);
	}
}