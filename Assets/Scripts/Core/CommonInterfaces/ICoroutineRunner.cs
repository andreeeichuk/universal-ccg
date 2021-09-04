using System.Collections;
using UnityEngine;

namespace UniversalCCG.Core.CommonInterfaces
{
	public interface ICoroutineRunner
	{
		Coroutine StartCoroutine(IEnumerator coroutine);
		void StopCoroutine(Coroutine coroutine);
	}
}