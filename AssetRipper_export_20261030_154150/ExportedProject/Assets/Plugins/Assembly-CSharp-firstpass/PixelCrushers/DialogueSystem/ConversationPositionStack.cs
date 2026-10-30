using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ConversationPositionStack : MonoBehaviour
	{
		[Tooltip("Clear stack when new conversation starts. Only applies if component is on Dialogue Manager.")]
		public bool clearOnConversationStart;

		[Tooltip("Typically leave unticked so temporary Dialogue Manager's don't unregister your functions.")]
		public bool unregisterOnDisable;

		[Tooltip("Push current dialogue entry instead of its follow-up entry. Use care if ticked; can cause to loop back on itself infinitely.")]
		public bool pushCurrentEntry;

		private static Stack<DialogueEntry> s_stack;

		public static bool s_pushCurrentEntry;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnConversationStart(Transform actor)
		{
		}

		public static void PushConversationPosition()
		{
		}

		public static void PopConversationPosition()
		{
		}

		public static void ClearConversationPositionStack()
		{
		}
	}
}
