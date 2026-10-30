using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class DialogueSystemSceneEvents : MonoBehaviour
	{
		[HelpBox("Do not remove this GameObject. It contains UnityEvents referenced by a dialogue database. This GameObject should not be a child of the Dialogue Manager or marked as Don't Destroy On Load.", HelpBoxMessageType.Info)]
		public List<DialogueEntrySceneEvent> dialogueEntrySceneEvents;

		private static DialogueSystemSceneEvents m_sceneInstance;

		public static DialogueSystemSceneEvents sceneInstance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public static int AddNewDialogueEntrySceneEvent(out string guid)
		{
			guid = null;
			return 0;
		}

		public static void RemoveDialogueEntrySceneEvent(string guid)
		{
		}

		public static DialogueEntrySceneEvent GetDialogueEntrySceneEvent(string guid)
		{
			return null;
		}

		public static int GetDialogueEntrySceneEventIndex(string guid)
		{
			return 0;
		}
	}
}
