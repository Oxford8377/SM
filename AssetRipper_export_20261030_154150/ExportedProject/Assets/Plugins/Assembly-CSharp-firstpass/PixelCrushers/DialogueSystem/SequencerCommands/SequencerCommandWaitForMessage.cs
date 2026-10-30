using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.SequencerCommands
{
	[AddComponentMenu(null)]
	public class SequencerCommandWaitForMessage : SequencerCommand
	{
		private List<string> requiredMessages;

		public void Awake()
		{
		}

		public void OnSequencerMessage(string message)
		{
		}
	}
}
