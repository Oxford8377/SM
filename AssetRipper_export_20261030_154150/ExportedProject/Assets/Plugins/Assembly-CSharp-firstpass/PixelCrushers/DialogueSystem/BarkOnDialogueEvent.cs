using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class BarkOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class BarkAction : Action
		{
			public Transform speaker;

			public Transform listener;

			[ConversationPopup(false, false)]
			public string conversation;
		}

		public BarkAction[] onStart;

		public BarkAction[] onEnd;

		[Tooltip("The order in which to bark dialogue entries.")]
		public BarkOrder barkOrder;

		private BarkHistory barkHistory;

		public Sequencer sequencer { get; private set; }

		private void Awake()
		{
		}

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(BarkAction[] actions, Transform actor)
		{
		}

		public void DoAction(BarkAction action, Transform actor)
		{
		}
	}
}
