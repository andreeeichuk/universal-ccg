using System.Collections;
using UnityEngine;

namespace UniversalCCG.UI.Pages
{
	public class LoadingScreen : MonoBehaviour, IPage
	{
		[SerializeField] private CanvasGroup canvasGroup;
		
		private const float FadeStep = 0.03f;

		private void Awake()
		{
			SetAsLastChild();
		}

		public void Show()
		{
			gameObject.SetActive(true);
			canvasGroup.alpha = 1;
		}

		public void Hide()
		{
			StartCoroutine(FadeOut());
		}

		private void SetAsLastChild()
		{
			transform.SetAsLastSibling();
		}

		private IEnumerator FadeOut()
		{
			while (canvasGroup.alpha > 0)
			{
				canvasGroup.alpha -= FadeStep;
				yield return new WaitForSeconds(FadeStep);
			}
			
			gameObject.SetActive(false);
		}
	}
}