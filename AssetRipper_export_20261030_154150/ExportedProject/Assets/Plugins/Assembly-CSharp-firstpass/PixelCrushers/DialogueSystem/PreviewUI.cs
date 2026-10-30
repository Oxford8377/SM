using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	[ExecuteInEditMode]
	public class PreviewUI : MonoBehaviour
	{
		private string message;

		private float endTime;

		private int lineOffset;

		private bool computedRect;

		private Rect rect;

		private const float DefaultSequenceDuration = 1f;

		private const float MinSubtitleSeconds = 1f;

		private static bool hasLookedForTypewriter;

		private static float typewriterCharsPerSecond;

		private static void GetDialogueEntry(string conversationTitle, int startingEntryID, int numContinues, out DialogueEntry entry, out bool isPlayer)
		{
			entry = null;
			isPlayer = default(bool);
		}

		public static string GetDialogueText(string conversationTitle, int startingEntryID, int numContinues = 0)
		{
			return null;
		}

		public static string GetSequence(string conversationTitle, int startingEntryID, out DialogueEntry entry, int numContinues = 0)
		{
			entry = null;
			return null;
		}

		private static string GetEntrytag(DialogueEntry entry)
		{
			return null;
		}

		private static string GetDefaultSequence(bool isPlayer)
		{
			return null;
		}

		public static float GetSequenceDuration(string conversationTitle, int startingEntryID, int numContinues = 0)
		{
			return 0f;
		}

		private static float GetTypewriterLength(string text)
		{
			return 0f;
		}

		private static float GetAudioLength(string command, string sequence, bool lipSync)
		{
			return 0f;
		}

		private static AudioClip LoadAudioClip(string audioFileName)
		{
			return null;
		}

		public static void ShowMessage(string message, float duration, int lineOffset)
		{
		}

		protected void Show(string message, float duration, int lineOffset)
		{
		}

		private void OnGUI()
		{
		}

		private void Update()
		{
		}
	}
}
