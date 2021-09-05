namespace UniversalCCG.UI.Interfaces
{
	public interface IUIManager
	{
		void SetCurrentPage<TPage>() where TPage : IPage;
	}
}