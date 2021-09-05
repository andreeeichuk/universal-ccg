using System;
using System.Collections.Generic;
using UnityEngine;
using UniversalCCG.UI.Interfaces;

namespace UniversalCCG.UI.Managers
{
	public class MainUIManager : MonoBehaviour, IUIManager
	{
		[SerializeField] private Transform pagesParent;

		public IPage CurrentPage { get; private set; }

		private Dictionary<Type, IPage> _pagesByType;

		#region Unity Callbacks

		private void Awake()
		{
			InitializePages();
		}

		#endregion

		public void SetCurrentPage<TPage>() where TPage : IPage
		{
			_pagesByType.TryGetValue(typeof(TPage), out IPage page);
			SetCurrentPage(page);
		}

		private void SetCurrentPage(IPage page)
		{
			CurrentPage?.Hide();
			
			if(page == null) return;

			CurrentPage = page;
			page.Show();
		}

		private void InitializePages()
		{
			_pagesByType = new Dictionary<Type, IPage>();
			foreach (Transform pageTransform in pagesParent)
			{
				pageTransform.gameObject.SetActive(false);
				IPage page = pageTransform.GetComponent<IPage>();
				if(page==null) continue;
				_pagesByType[page.GetType()] = page;
			}
		}
	}
}