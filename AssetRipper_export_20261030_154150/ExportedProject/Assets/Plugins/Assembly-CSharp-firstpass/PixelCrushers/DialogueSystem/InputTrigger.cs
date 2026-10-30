using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class InputTrigger
	{
		[Tooltip("This key fires the trigger.")]
		public KeyCode key;

		[Tooltip("This button fires the trigger. The button name must be defined in your project's Input Settings.")]
		public string buttonName;

		public bool isDown => false;

		public bool IsDown => false;

		public InputTrigger()
		{
		}

		public InputTrigger(KeyCode key)
		{
		}

		public InputTrigger(string buttonName)
		{
		}

		public InputTrigger(KeyCode key, string buttonName)
		{
		}
	}
}
