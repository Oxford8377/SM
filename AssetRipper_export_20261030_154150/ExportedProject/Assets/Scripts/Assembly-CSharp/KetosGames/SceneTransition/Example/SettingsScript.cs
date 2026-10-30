using UnityEngine;
using UnityEngine.UI;

namespace KetosGames.SceneTransition.Example
{
	public class SettingsScript : MonoBehaviour
	{
		public Toggle VRSupport;

		public Toggle UseSceneForLoadingScreen;

		public Toggle FadeInLoadingScreen;

		public Toggle FadeOutLoadingScreen;

		public InputField FadeSeconds;

		public InputField MinimumLoadingScreenSeconds;

		public InputField FadeColor;

		private SceneLoader SceneLoaderInstance;

		private void Start()
		{
		}

		public void ClickVRSupport()
		{
		}

		public void ClickUseSceneForLoadingScreen()
		{
		}

		public void ClickFadeInLoadingScreen()
		{
		}

		public void ClickFadeOutLoadingScreen()
		{
		}

		public void ChangeFadeSeconds()
		{
		}

		public void ChangeMinimumLoadingScreenSeconds()
		{
		}

		public void ChangeFadeColor()
		{
		}

		private string ColorToHex(Color32 color)
		{
			return null;
		}

		private Color HexToColor(string hex)
		{
			return default(Color);
		}

		private void UpdateVisibleSettings()
		{
		}
	}
}
