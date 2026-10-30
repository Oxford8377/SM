using System;
using UnityEngine;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class PlaySequenceBehaviour : PlayableBehaviour
	{
		[TextArea(5, 5)]
		[Tooltip("Play this sequence.")]
		public string sequence;

		[Tooltip("(Optional) The other subject in the sequence.")]
		public Transform listener;
	}
}
