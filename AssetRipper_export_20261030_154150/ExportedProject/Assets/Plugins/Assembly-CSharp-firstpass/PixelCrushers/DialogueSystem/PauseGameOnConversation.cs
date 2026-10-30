using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class PauseGameOnConversation : MonoBehaviour
	{
		private float preConversationTimeScale;

		public void OnConversationStart(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}
	}
}
