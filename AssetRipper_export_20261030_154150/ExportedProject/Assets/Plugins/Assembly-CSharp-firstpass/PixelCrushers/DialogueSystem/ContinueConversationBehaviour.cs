using System;
using UnityEngine;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class ContinueConversationBehaviour : PlayableBehaviour
	{
		public enum Operation
		{
			Continue = 0,
			ClearSubtitleText = 1
		}

		[Tooltip("Continue past current subtitle or just clear text in subtitle panels.")]
		public Operation operation;

		[Tooltip("If Operation is Clear Subtitle Text, clear these panel(s).")]
		public int clearPanelNumber;

		public bool clearAllPanels;
	}
}
