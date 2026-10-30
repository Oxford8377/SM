using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UnityUIContinueButtonFastForward : MonoBehaviour
	{
		[Tooltip("Dialogue UI that the continue button affects.")]
		public UnityUIDialogueUI dialogueUI;

		[Tooltip("Typewriter effect to fast forward if it's not done playing.")]
		public UnityUITypewriterEffect typewriterEffect;

		[Tooltip("Hide the continue button when continuing.")]
		public bool hideContinueButtonOnContinue;

		private Button continueButton;

		public virtual void Awake()
		{
		}

		public virtual void OnFastForward()
		{
		}
	}
}
