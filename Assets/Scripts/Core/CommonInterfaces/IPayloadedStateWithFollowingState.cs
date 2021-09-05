namespace UniversalCCG.Core.CommonInterfaces
{
	public interface IPayloadedStateWithFollowingState<in TPayload> : IPayloadedState<TPayload>
	{
		void Enter<TNextState>(TPayload payload) where TNextState : class, IState;
	}
}