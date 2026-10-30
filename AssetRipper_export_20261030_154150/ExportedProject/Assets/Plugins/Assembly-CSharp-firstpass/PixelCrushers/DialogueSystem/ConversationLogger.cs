using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ConversationLogger : MonoBehaviour
	{
		[Tooltip("Log player lines in this color.")]
		public Color playerColor;

		[Tooltip("Log NPC lines in this color.")]
		public Color npcColor;

		public void OnConversationStart(Transform actor)
		{
		}

		public void OnConversationLine(Subtitle subtitle)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		private string GetActorName(Transform actor)
		{
			return null;
		}

		private string GetActorColor(Subtitle subtitle)
		{
			return null;
		}

		public void OnPrepareConversationLine(DialogueEntry entry)
		{
		}

		public void OnConversationLineCancelled(Subtitle subtitle)
		{
		}

		public void OnConversationLineEnd(Subtitle subtitle)
		{
		}

		public void OnConversationResponseMenu(Response[] responses)
		{
		}

		public void OnConversationTimeout()
		{
		}

		public void OnLinkedConversationStart(Transform actor)
		{
		}
	}
}
