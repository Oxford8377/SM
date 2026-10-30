using System;
using UnityEngine;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class SetQuestStateBehaviour : PlayableBehaviour
	{
		[QuestPopup(false)]
		public string quest;

		[Tooltip("Change the quest's main state.")]
		public bool setQuestState;

		[QuestState]
		public QuestState questState;

		[Tooltip("Change a quest entry's state.")]
		public bool setQuestEntryState;

		public int questEntryNumber;

		[QuestState]
		public QuestState questEntryState;
	}
}
