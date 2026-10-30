using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class OverrideUnityUIDialogueControls : MonoBehaviour
	{
		[Tooltip("Use these controls when playing subtitles through this actor")]
		public UnityUISubtitleControls subtitle;

		[Tooltip("Use these controls when showing subtitle reminders for actor")]
		public UnityUISubtitleControls subtitleReminder;

		[Tooltip("Use these controls when showing a response menu involving this actor")]
		public UnityUIResponseMenuControls responseMenu;

		private bool checkedContinueButton;

		private void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void ApplyToDialogueUI(UnityUIDialogueUI ui)
		{
		}
	}
}
