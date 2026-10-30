using System;
using UnityEngine;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class StartConversationBehaviour : PlayableBehaviour
	{
		[Tooltip("(Optional) The other participant.")]
		public Transform conversant;

		[Tooltip("The conversation to start.")]
		[ConversationPopup(true, false)]
		public string conversation;

		[Tooltip("Jump to a specific dialogue entry instead of starting from the conversation's START node.")]
		public bool jumpToSpecificEntry;

		[Tooltip("Dialogue entry to jump to.")]
		public int entryID;

		[Tooltip("Stop any active conversations before starting this one.")]
		public bool exclusive;

		public string GetEditorDialogueText()
		{
			return null;
		}
	}
}
