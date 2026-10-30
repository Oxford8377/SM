using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class SequencerShortcuts : MonoBehaviour
	{
		[Serializable]
		public class Shortcut
		{
			[Tooltip("Shortcut. Wrap in double braces to reference in sequences, such as {{foo}}.")]
			public string shortcut;

			[TextArea]
			[Tooltip("Value to replace shortcut with.")]
			public string value;
		}

		public Shortcut[] shortcuts;

		[Tooltip("Optionally assign GameObjects referenced by name in sequencer commands below. Prevents having to search for them at runtime.")]
		public Transform[] referencedSubjects;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
