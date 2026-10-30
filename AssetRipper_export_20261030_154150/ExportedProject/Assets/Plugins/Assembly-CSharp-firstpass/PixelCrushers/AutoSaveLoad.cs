using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class AutoSaveLoad : MonoBehaviour
	{
		[Tooltip("Save to this slot.")]
		public int saveSlotNumber;

		[Tooltip("Don't auto-save in these scene indices.")]
		public int[] dontSaveInScenes;

		[Tooltip("Load the saved game when this component starts.")]
		public bool loadOnStart;

		[Tooltip("Save when the player quits the app.")]
		public bool saveOnQuit;

		[Tooltip("Save when the player pauses or minimizes the app; tick this for mobile builds.")]
		public bool saveOnPause;

		[Tooltip("Save when the app loses focus.")]
		public bool saveOnLoseFocus;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private bool OnWantsToQuit()
		{
			return false;
		}

		private void CheckSaveOnQuit()
		{
		}

		private void OnApplicationPause(bool paused)
		{
		}

		private void OnApplicationFocus(bool focusStatus)
		{
		}

		private bool CanSaveInThisScene()
		{
			return false;
		}

		public void Restart(string startingSceneName)
		{
		}
	}
}
