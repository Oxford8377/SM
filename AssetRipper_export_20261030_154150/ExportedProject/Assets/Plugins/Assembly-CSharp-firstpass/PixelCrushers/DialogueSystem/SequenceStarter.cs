using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public abstract class SequenceStarter : DialogueEventStarter
	{
		[Tooltip("The sequence to play.")]
		[TextArea(1, 20)]
		public string sequence;

		[Tooltip("Speaker to use for the sequence (leave unassigned if no speaker is needed). Sequencer commands can reference 'speaker' and 'listener', so you may need to define them here.")]
		public Transform speaker;

		[Tooltip("Listener to use for the sequence (leave unassigned if no listener is needed). Sequencer commands can reference 'speaker' and 'listener', so you may need to define them here.")]
		public Transform listener;

		public Condition condition;

		private bool tryingToStart;

		public void TryStartSequence(Transform actor)
		{
		}

		public void TryStartSequence(Transform actor, Transform interactor)
		{
		}
	}
}
