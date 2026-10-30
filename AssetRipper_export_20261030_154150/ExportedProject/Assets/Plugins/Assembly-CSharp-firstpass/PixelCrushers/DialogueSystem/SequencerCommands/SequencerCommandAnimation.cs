using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	[AddComponentMenu(null)]
	public class SequencerCommandAnimation : SequencerCommand
	{
		private Transform subject;

		private int nextAnimationIndex;

		private float stopTime;

		private Animation anim;

		public void Start()
		{
		}

		private void TryAnimationClip(string clipName)
		{
		}

		public void Update()
		{
		}
	}
}
