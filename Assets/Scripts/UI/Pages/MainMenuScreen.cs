using UnityEngine;

namespace UniversalCCG.UI.Pages
{
	public class MainMenuScreen : MonoBehaviour, IPage
	{
		public void Show()
		{
			gameObject.SetActive(true);
		}

		public void Hide()
		{
			gameObject.SetActive(false);
		}
	}
}