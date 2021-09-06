using UniversalCCG.UI.Pages;

namespace UniversalCCG.UI.Managers
{
	public interface IUIManager
	{
		void SetCurrentPage<TPage>() where TPage : IPage;
	}
}