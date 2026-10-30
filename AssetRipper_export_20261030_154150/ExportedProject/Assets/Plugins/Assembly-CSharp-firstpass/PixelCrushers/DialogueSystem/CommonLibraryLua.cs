using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class CommonLibraryLua : MonoBehaviour
	{
		[Tooltip("Unregister functions when this component is disabled. Leave unticked if this script is on Dialogue Manager or other persistent GameObject.")]
		public bool unregisterOnDisable;

		private static bool s_registered;

		private bool didIRegister;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void SendMessageSystem(string message, string parameter)
		{
		}

		public void SendMessageSystemString(string message, string parameter, string value)
		{
		}

		public void SendMessageSystemInt(string message, string parameter, double value)
		{
		}
	}
}
