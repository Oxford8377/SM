using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class MessageSystemLogger : MonoBehaviour
	{
		[Tooltip("Log a message when this GameObject sends a message to the Message System.")]
		public bool logWhenSendingMessages;

		[Tooltip("Log a message when this GameObject receives a message from the Message System.")]
		public bool logWhenReceivingMessages;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
