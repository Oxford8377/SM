using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class SaveSystemEvents : MonoBehaviour
	{
		public UnityEvent onSaveStart;

		public UnityEvent onSaveEnd;

		public UnityEvent onLoadStart;

		public UnityEvent onLoadEnd;

		public UnityEvent onSaveDataApplied;

		public UnityEvent onSceneLoad;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RegisterEvents()
		{
		}

		private void UnregisterEvents()
		{
		}

		private void OnSaveStarted()
		{
		}

		private void OnSaveEnded()
		{
		}

		private void OnLoadStarted()
		{
		}

		private void OnLoadEnded()
		{
		}

		private void OnSaveDataApplied()
		{
		}

		private void OnSceneLoaded(string sceneName, int sceneIndex)
		{
		}
	}
}
