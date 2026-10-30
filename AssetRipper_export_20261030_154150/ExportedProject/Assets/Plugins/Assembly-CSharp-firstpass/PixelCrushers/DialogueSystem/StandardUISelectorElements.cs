using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUISelectorElements : MonoBehaviour
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		[HelpBox("If a GameObject with a Selector or Proximity Selector has a Selector Use Standard UI Elements component, it will use these UI elements.", HelpBoxMessageType.None)]
		[Tooltip("(Optional) Main panel. Assign if you have created an entire panel for selector.")]
		public Graphic mainGraphic;

		[Tooltip("Text element for name of current selection.")]
		public UITextField nameText;

		[Tooltip("Text element for use message (e.g., 'Press spacebar to use').")]
		public UITextField useMessageText;

		[Tooltip("Use In Range and Out Of Range text colors defined below.")]
		public bool useRangeColors;

		[Tooltip("Set text elements to this color when selector is in range to use selection.")]
		public Color inRangeColor;

		[Tooltip("Set text elements to this color when selector is out of range.")]
		public Color outOfRangeColor;

		[Tooltip("Optional graphic to show if selection is in range.")]
		public Graphic reticleInRange;

		[Tooltip("Optional graphic to show if selection is out of range.")]
		public Graphic reticleOutOfRange;

		public AnimationTransitions animationTransitions;

		private static List<StandardUISelectorElements> m_instances;

		public Animator animator { get; private set; }

		public static List<StandardUISelectorElements> instances => null;

		public static StandardUISelectorElements instance => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}
	}
}
