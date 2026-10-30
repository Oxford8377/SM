using System;
using UnityEngine;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class BarkBehaviour : PlayableBehaviour
	{
		[Tooltip("Get bark text from a conversation.")]
		public bool useConversation;

		[ConversationPopup(true, false)]
		[Tooltip("Get the bark text from this conversation.")]
		public string conversation;

		[Tooltip("Bark a specific dialogue entry instead of starting from the conversation's START node.")]
		public bool barkSpecificEntry;

		[Tooltip("Dialogue entry to bark.")]
		public int entryID;

		[Tooltip("Bark this text.")]
		public string text;

		[Tooltip("(Optional) Barker is barking to this listener.")]
		public Transform listener;

		public string GetEditorBarkText()
		{
			return null;
		}
	}
}
