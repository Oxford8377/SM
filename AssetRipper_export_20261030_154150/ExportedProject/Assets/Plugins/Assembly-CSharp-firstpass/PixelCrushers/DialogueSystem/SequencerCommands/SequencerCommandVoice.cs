using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	[AddComponentMenu(null)]
	public class SequencerCommandVoice : SequencerCommand
	{
		private const float DefaultCrossfadeDuration = 0.3f;

		private float stopTime;

		private Transform subject;

		private string finalClipName;

		private Animation anim;

		private Animator animator;

		private AudioSource audioSource;

		private AudioClip audioClip;

		private int layer;

		private float crossfadeDuration;

		public void Start()
		{
		}

		public void Update()
		{
		}

		public void OnDialogueSystemPause()
		{
		}

		public void OnDialogueSystemUnpause()
		{
		}

		public void OnDestroy()
		{
		}
	}
}
