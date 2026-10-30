using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardBarkUI : AbstractBarkUI
	{
		[Serializable]
		public class AnimationTransitions
		{
			public string showTrigger;

			public string hideTrigger;
		}

		[Tooltip("Optional canvas group, for example to play fade animations.")]
		public CanvasGroup canvasGroup;

		[Tooltip("UI text control for bark text.")]
		public UITextField barkText;

		[Tooltip("Optional UI text control for barker's name if Include Name is ticked. If unassigned and Include Name is ticked, name is prepended to Bark Text.")]
		public UITextField nameText;

		[Tooltip("If Name Text is unassigned, prepend barker's name to Bark Text.")]
		public bool includeName;

		[Tooltip("Optional to show barker's portrait image.")]
		public Image portraitImage;

		[Tooltip("Show barker's portrait image.")]
		public bool showPortraitImage;

		[HideInInspector]
		public float doneTime;

		public AnimationTransitions animationTransitions;

		[Tooltip("The duration in seconds to show the bark text before fading it out. If zero, use the Dialogue Manager's Bark Settings.")]
		public float duration;

		[Tooltip("Keep bark canvas anchor point always in camera view.")]
		public bool keepInView;

		[Tooltip("Keep the bark text onscreen until the sequence ends.")]
		public bool waitUntilSequenceEnds;

		[Tooltip("If bark is visible and waiting for sequence to end, but new bark wants to show, cancel wait for previous sequence.")]
		public bool cancelWaitUntilSequenceEndsIfReplacingBark;

		[Tooltip("Wait for an OnContinue message.")]
		public bool waitForContinueButton;

		public BarkSubtitleSetting textDisplaySetting;

		protected int numSequencesActive;

		protected bool hasEverBarked;

		protected Canvas canvas { get; set; }

		protected Animator animator { get; set; }

		protected AbstractTypewriterEffect typewriter { get; set; }

		protected Vector3 originalCanvasLocalPosition { get; set; }

		public override bool isPlaying => false;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual bool ShouldShowText(Subtitle subtitle)
		{
			return false;
		}

		public override void Bark(Subtitle subtitle)
		{
		}

		protected virtual void SetUIElementsActive(bool value)
		{
		}

		public virtual void OnBarkEnd(Transform actor)
		{
		}

		protected virtual bool IsActorMe(Transform actor)
		{
			return false;
		}

		public virtual void OnContinue()
		{
		}

		public override void Hide()
		{
		}

		protected virtual bool CanTriggerAnimations()
		{
			return false;
		}
	}
}
