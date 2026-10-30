using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class QuestCondition
	{
		public string questName;

		[Tooltip("The allowable quest states for the condition to be true.")]
		[QuestState]
		[BitMask(typeof(QuestState))]
		public QuestState questState;

		[Tooltip("Check quest entry state.")]
		public bool checkQuestEntry;

		[QuestEntryPopup]
		public int entryNumber;

		[QuestState]
		[BitMask(typeof(QuestState))]
		[Tooltip("If quest entry is specified, the allowable quest entry states for the condition to be true.")]
		public QuestState questEntryState;

		public bool IsTrue => false;
	}
}
