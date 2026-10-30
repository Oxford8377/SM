using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUISubtitlePanel : UIPanel
	{
		[CompilerGenerated]
		private sealed class _003CShowSubtitleAfterClosing_003Ed__100 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUISubtitlePanel _003C_003E4__this;

			public Subtitle subtitle;

			private float _003CsafeguardTime_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowSubtitleAfterClosing_003Ed__100(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CFocusWhenOpen_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUISubtitlePanel _003C_003E4__this;

			private float _003Ctimeout_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CFocusWhenOpen_003Ed__108(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowContinueButtonAfterBlockDuration_003Ed__117 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUISubtitlePanel _003C_003E4__this;

			private float _003Ctimeout_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowContinueButtonAfterBlockDuration_003Ed__117(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetSubtitleTextContentAfterOpen_003Ed__124 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUISubtitlePanel _003C_003E4__this;

			public Subtitle subtitle;

			private float _003Ctimeout_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSetSubtitleTextContentAfterOpen_003Ed__124(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CStartTypingWhenFocused_003Ed__126 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UITextField subtitleText;

			public StandardUISubtitlePanel _003C_003E4__this;

			public string text;

			public int fromIndex;

			private float _003Ctimeout_003E5__2;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStartTypingWhenFocused_003Ed__126(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSetAnimatorAtEndOfFrame_003Ed__132 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUISubtitlePanel _003C_003E4__this;

			public RuntimeAnimatorController animatorController;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSetAnimatorAtEndOfFrame_003Ed__132(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Tooltip("(Optional) Main panel for subtitle.")]
		public RectTransform panel;

		[Tooltip("(Optional) Image for actor's portrait.")]
		public Image portraitImage;

		[Tooltip("(Optional) Text element for actor's name.")]
		public UITextField portraitName;

		[Tooltip("Subtitle text.")]
		public UITextField subtitleText;

		[Tooltip("Add speaker's name to subtitle text.")]
		public bool addSpeakerName;

		[Tooltip("Format to add speaker name, where {0} is name and {1} is subtitle text.")]
		public string addSpeakerNameFormat;

		[Tooltip("Each subtitle adds to Subtitle Text instead of replacing it.")]
		public bool accumulateText;

		[Tooltip("If Accumulate Text is ticked, accumulate up to this many lines, removing the oldest lines when over the limit.")]
		public int maxLines;

		[Tooltip("If panel has a typewriter effect, don't start typing until panel's Show animation has completed.")]
		public bool delayTypewriterUntilOpen;

		[Tooltip("(Optional) Continue button. Only shown if Dialogue Manager's Continue Button mode uses continue button.")]
		public Button continueButton;

		[Tooltip("If non-zero, prevent continue button clicks for this duration in seconds when opening subtitle panel.")]
		public float blockInputDuration;

		[Tooltip("When the subtitle UI elements should be visible.")]
		public UIVisibility visibility;

		[Tooltip("When focusing panel, set this animator trigger.")]
		public string focusAnimationTrigger;

		[Tooltip("When unfocusing panel, set this animator trigger.")]
		public string unfocusAnimationTrigger;

		[Tooltip("If a player actor uses this panel, don't show player portrait name & image; keep previous NPC portrait visible instead.")]
		public bool onlyShowNPCPortraits;

		[Tooltip("Check Dialogue Actors for portrait animator controllers. Portrait image must have an Animator.")]
		public bool useAnimatedPortraits;

		[Tooltip("Set Portrait Image to actor portrait's native size. Image's Rect Transform can't use Stretch anchors.")]
		public bool usePortraitNativeSize;

		[Tooltip("Wait for panel state to be Open before showing subtitle.")]
		public bool waitForOpen;

		[Tooltip("Wait for panels within this dialogue UI (not external panels) to close before showing.")]
		public bool waitForClose;

		[Tooltip("Clear text when closing panel, including when hiding using SetDialoguePanel().")]
		public bool clearTextOnClose;

		[Tooltip("Clear text when any conversation starts.")]
		public bool clearTextOnConversationStart;

		[Tooltip("If Subtitle Text doesn't have a typewriter effect, to enable scroll to bottom add UIScrollbarEnabler to Scroll Rect and assign it here.")]
		public UIScrollbarEnabler scrollbarEnabler;

		public UnityEvent onFocus;

		public UnityEvent onUnfocus;

		[Tooltip("Panel is currently in focused state.")]
		[SerializeField]
		private bool m_hasFocus;

		[Tooltip("Panel is playing the focus animation.")]
		[SerializeField]
		private bool m_isFocusing;

		private Subtitle m_currentSubtitle;

		private bool m_haveSavedOriginalColor;

		private string m_accumulatedText;

		protected int numAccumulatedLines;

		private Animator m_portraitAnimator;

		private Animator m_panelAnimator;

		private bool m_isDefaultNPCPanel;

		private bool m_isDefaultPCPanel;

		private int m_panelNumber;

		public Transform m_actorOverridingPanel;

		private int m_lastActorID;

		protected int frameLastSetContent;

		protected bool shouldShowContinueButton;

		protected const float WaitForCloseTimeoutDuration = 8f;

		private StandardDialogueUI m_dialogueUI;

		protected Coroutine m_focusWhenOpenCoroutine;

		protected Coroutine m_showAfterClosingCoroutine;

		protected Coroutine m_setAnimatorCoroutine;

		public bool hasFocus
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isFocusing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public override bool waitForShowAnimation => false;

		public virtual Subtitle currentSubtitle
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public string portraitActorName { get; protected set; }

		protected bool haveSavedOriginalColor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected Color originalColor { get; set; }

		public string accumulatedText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual Animator animator
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isDefaultNPCPanel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isDefaultPCPanel
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int panelNumber
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Transform actorOverridingPanel
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected int lastActorID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public StandardDialogueUI dialogueUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		public AbstractTypewriterEffect GetTypewriter()
		{
			return null;
		}

		public bool HasTypewriter()
		{
			return false;
		}

		public float GetTypewriterSpeed()
		{
			return 0f;
		}

		public void SetTypewriterSpeed(float charactersPerSecond)
		{
		}

		public virtual void OpenOnStartConversation(Sprite portraitSprite, string portraitName, DialogueActor dialogueActor)
		{
		}

		[Obsolete("Use OpenOnStartConversation(Sprite,string,DialogueActor) instead.")]
		public virtual void OpenOnStartConversation(Texture2D portraitTexture, string portraitName, DialogueActor dialogueActor)
		{
		}

		public virtual void OnConversationStart(Transform actor)
		{
		}

		public virtual void ShowSubtitle(Subtitle subtitle)
		{
		}

		protected virtual void ShowSubtitleNow(Subtitle subtitle)
		{
		}

		[IteratorStateMachine(typeof(_003CShowSubtitleAfterClosing_003Ed__100))]
		protected virtual IEnumerator ShowSubtitleAfterClosing(Subtitle subtitle)
		{
			return null;
		}

		protected virtual void StopShowAfterClosingCoroutine()
		{
		}

		public virtual void HideSubtitle(Subtitle subtitle)
		{
		}

		public virtual void HideImmediate()
		{
		}

		protected override void OnHidden()
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		public virtual void Focus()
		{
		}

		[IteratorStateMachine(typeof(_003CFocusWhenOpen_003Ed__108))]
		protected IEnumerator FocusWhenOpen()
		{
			return null;
		}

		protected virtual void FocusNow()
		{
		}

		private void OnFocused()
		{
		}

		public virtual void Unfocus()
		{
		}

		public virtual void ActivateUIElements()
		{
		}

		public virtual void DeactivateUIElements()
		{
		}

		protected virtual void SetUIElementsActive(bool value)
		{
		}

		public virtual void ClearText()
		{
		}

		public virtual void ShowContinueButton()
		{
		}

		[IteratorStateMachine(typeof(_003CShowContinueButtonAfterBlockDuration_003Ed__117))]
		protected virtual IEnumerator ShowContinueButtonAfterBlockDuration()
		{
			return null;
		}

		protected virtual void ShowContinueButtonNow()
		{
		}

		public virtual void HideContinueButton()
		{
		}

		public virtual void FinishSubtitle()
		{
		}

		public virtual void Select(bool allowStealFocus = true)
		{
		}

		public virtual void OnContinue()
		{
		}

		public virtual void SetContent(Subtitle subtitle)
		{
		}

		[IteratorStateMachine(typeof(_003CSetSubtitleTextContentAfterOpen_003Ed__124))]
		protected virtual IEnumerator SetSubtitleTextContentAfterOpen(Subtitle subtitle)
		{
			return null;
		}

		protected virtual void SetSubtitleTextContent(Subtitle subtitle)
		{
		}

		[IteratorStateMachine(typeof(_003CStartTypingWhenFocused_003Ed__126))]
		protected virtual IEnumerator StartTypingWhenFocused(UITextField subtitleText, string text, int fromIndex)
		{
			return null;
		}

		protected virtual void SetFormattedText(UITextField textField, string previousText, FormattedText formattedText)
		{
		}

		public virtual void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		protected virtual void SetPortraitImage(Sprite sprite)
		{
		}

		public virtual void CheckSubtitleAnimator(Subtitle subtitle)
		{
		}

		protected virtual void CheckDialogueActorAnimator(DialogueActor dialogueActor)
		{
		}

		[IteratorStateMachine(typeof(_003CSetAnimatorAtEndOfFrame_003Ed__132))]
		protected virtual IEnumerator SetAnimatorAtEndOfFrame(RuntimeAnimatorController animatorController)
		{
			return null;
		}
	}
}
