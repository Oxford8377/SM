using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UnityUIBarkUI : AbstractBarkUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		[Tooltip("Optional canvas group, for example to play fade animations.")]
		public CanvasGroup canvasGroup;

		[Tooltip("UI text control for the bark text.")]
		public Text barkText;

		[Tooltip("Optional UI text control for the actor's name if Include Name is ticked. If unassigned and Include Name is ticked, the name is prepended to the Bark Text.")]
		public Text nameText;

		[Tooltip("Show the barker's name.")]
		public bool includeName;

		[HideInInspector]
		public float doneTime;

		public AnimationTransitions animationTransitions;

		[Tooltip("The duration in seconds to show the bark text before fading it out. If zero, use the Dialogue Manager's Bark Settings.")]
		public float duration;

		[Tooltip("Keep the bark text onscreen until the sequence ends.")]
		public bool waitUntilSequenceEnds;

		public bool waitForContinueButton;

		public BarkSubtitleSetting textDisplaySetting;

		private Canvas canvas;

		private Animator animator;

		public override bool isPlaying => false;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		public bool ShouldShowText(Subtitle subtitle)
		{
			return false;
		}

		public override void Bark(Subtitle subtitle)
		{
		}

		private void SetUIElementsActive(bool value)
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnContinue()
		{
		}

		public override void Hide()
		{
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}
	}
}
