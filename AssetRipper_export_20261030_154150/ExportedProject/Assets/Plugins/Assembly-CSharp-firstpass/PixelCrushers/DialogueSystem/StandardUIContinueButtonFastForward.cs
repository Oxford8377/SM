using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUIContinueButtonFastForward : MonoBehaviour
	{
		public AudioSource ContinueSound;

		[Tooltip("Dialogue UI that the continue button affects.")]
		public StandardDialogueUI dialogueUI;

		[Tooltip("Typewriter effect to fast forward if it's not done playing.")]
		public AbstractTypewriterEffect typewriterEffect;

		[Tooltip("Hide the continue button when continuing.")]
		public bool hideContinueButtonOnContinue;

		[Tooltip("If subtitle is displaying, continue past it.")]
		public bool continueSubtitlePanel;

		[Tooltip("If alert is displaying, continue past it.")]
		public bool continueAlertPanel;

		protected Button continueButton;

		protected AbstractDialogueUI m_runtimeDialogueUI;

		protected virtual AbstractDialogueUI runtimeDialogueUI => null;

		public virtual void Awake()
		{
		}

		public virtual void OnFastForward()
		{
		}
	}
}
