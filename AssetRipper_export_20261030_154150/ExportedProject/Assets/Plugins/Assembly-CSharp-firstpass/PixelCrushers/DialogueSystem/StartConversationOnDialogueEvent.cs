using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StartConversationOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class ConversationAction : Action
		{
			public Transform speaker;

			public Transform listener;

			[ConversationPopup(false, false)]
			public string conversation;

			public bool skipIfNoValidEntries;
		}

		public ConversationAction[] onStart;

		public ConversationAction[] onEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(ConversationAction[] actions, Transform actor)
		{
		}

		public void DoAction(ConversationAction action, Transform actor)
		{
		}
	}
}
