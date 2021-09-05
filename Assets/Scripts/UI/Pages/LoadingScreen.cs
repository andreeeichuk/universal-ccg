using UnityEngine;
using UniversalCCG.UI.Interfaces;

namespace UniversalCCG.UI.Pages
{
	public class LoadingScreen : MonoBehaviour, IPage
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