using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public abstract class ConversationStarter : DialogueEventStarter
	{
		[Tooltip("Start this conversation.")]
		[ConversationPopup(true, false)]
		public string conversation;

		public Condition condition;

		[Tooltip("Only trigger if at least one entry's Conditions are currently true.")]
		public bool skipIfNoValidEntries;

		[Tooltip("Only trigger if no other conversation is already active.")]
		public bool exclusive;

		[Tooltip("The other actor (e.g., NPC). If unassigned, this GameObject.")]
		public Transform conversant;

		private bool tryingToStart;

		[HideInInspector]
		public bool useConversationTitlePicker;

		[HideInInspector]
		public DialogueDatabase selectedDatabase;

		public void TryStartConversation(Transform actor)
		{
		}

		public void TryStartConversation(Transform actor, Transform interactor)
		{
		}

		private void StartConversation(Transform actor)
		{
		}
	}
}
