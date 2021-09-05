namespace UniversalCCG.Core.CommonInterfaces
{
	public interface IPayloadedState<in TPayload> : IExitableState
	{
		void Enter(TPayload payload);
	}
}