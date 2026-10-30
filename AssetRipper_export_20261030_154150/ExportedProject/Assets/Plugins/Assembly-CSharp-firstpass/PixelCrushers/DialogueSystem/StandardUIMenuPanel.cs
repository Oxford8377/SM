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
	public class StandardUIMenuPanel : UIPanel
	{
		[CompilerGenerated]
		private sealed class _003CCheckTMProAutoScroll_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUIMenuPanel _003C_003E4__this;

			private UIScrollbarEnabler _003CuiScrollbarEnabler_003E5__2;

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
			public _003CCheckTMProAutoScroll_003Ed__52(int _003C_003E1__state)
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
		private sealed class _003CShowAfterPanelsClose_003Ed__53 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUIMenuPanel _003C_003E4__this;

			public Subtitle subtitle;

			public Response[] responses;

			public Transform target;

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
			public _003CShowAfterPanelsClose_003Ed__53(int _003C_003E1__state)
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
		private sealed class _003CFocusWhenOpen_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUIMenuPanel _003C_003E4__this;

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
			public _003CFocusWhenOpen_003Ed__57(int _003C_003E1__state)
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
		private sealed class _003CCheckScrollbarCoroutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardUIMenuPanel _003C_003E4__this;

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
			public _003CCheckScrollbarCoroutine_003Ed__68(int _003C_003E1__state)
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

		[Tooltip("(Optional) Main response menu panel.")]
		public Graphic panel;

		[Tooltip("(Optional) Image to show PC portrait during response menu.")]
		public Image pcImage;

		[Tooltip("(Optional) Text element to show PC name during response menu.")]
		public UITextField pcName;

		[Tooltip("Set PC Image to actor portrait's native size. Image's Rect Transform can't use Stretch anchors.")]
		public bool usePortraitNativeSize;

		[Tooltip("(Optional) Slider for timed menus.")]
		public Slider timerSlider;

		[Tooltip("Assign design-time positioned buttons starting with first or last button.")]
		public ResponseButtonAlignment buttonAlignment;

		[Tooltip("Show buttons that aren't assigned to any responses. If using a 'dialogue wheel' for example, you'll want to show unused buttons so the entire wheel structure is visible.")]
		public bool showUnusedButtons;

		[Tooltip("Design-time positioned response buttons. (Optional if Button Template is assigned.)")]
		public StandardUIResponseButton[] buttons;

		[Tooltip("Template from which to instantiate response buttons. (Optional if using Buttons list above.)")]
		public StandardUIResponseButton buttonTemplate;

		[Tooltip("If using Button Template, instantiate buttons under this GameObject.")]
		public Graphic buttonTemplateHolder;

		[Tooltip("(Optional) Scrollbar to use if instantiated button holder is in a scroll rect.")]
		public Scrollbar buttonTemplateScrollbar;

		[Tooltip("(Optional) Component that enables or disables scrollbar as necessary for content.")]
		public UIScrollbarEnabler scrollbarEnabler;

		[Tooltip("Reset the scroll bar to this value when preparing response menu. To skip resetting the scrollbar, specify a negative value.")]
		public float buttonTemplateScrollbarResetValue;

		[Tooltip("Automatically set up explicit joystick/keyboard navigation for instantiated template buttons instead of using Automatic navigation.")]
		public bool explicitNavigationForTemplateButtons;

		[Tooltip("If explicit navigation is enabled, loop around when navigating past end of menu.")]
		public bool loopExplicitNavigation;

		public UIAutonumberSettings autonumber;

		[Tooltip("If non-zero, prevent input for this duration in seconds when opening menu.")]
		public float blockInputDuration;

		[Tooltip("During block input duration, keep selected response button in selected visual state.")]
		public bool showSelectionWhileInputBlocked;

		[Tooltip("Log a warning if a response button text is blank.")]
		public bool warnOnEmptyResponseText;

		public UnityEvent onContentChanged;

		[Tooltip("When focusing panel, set this animator trigger.")]
		public string focusAnimationTrigger;

		[Tooltip("When unfocusing panel, set this animator trigger.")]
		public string unfocusAnimationTrigger;

		[Tooltip("Wait for panels within this dialogue UI (not external) to close before showing menu.")]
		public bool waitForClose;

		public UnityEvent onFocus;

		public UnityEvent onUnfocus;

		[SerializeField]
		[Tooltip("Panel is currently in focused state.")]
		private bool m_hasFocus;

		private List<GameObject> m_instantiatedButtons;

		private List<GameObject> m_instantiatedButtonPool;

		private string m_processedAutonumberFormat;

		private Coroutine m_scrollbarCoroutine;

		protected const float WaitForCloseTimeoutDuration = 8f;

		protected StandardUITimer m_timer;

		protected Action m_timeoutHandler;

		protected CanvasGroup m_mainCanvasGroup;

		protected static bool s_isInputDisabled;

		private StandardDialogueUI m_dialogueUI;

		public virtual bool hasFocus
		{
			get
			{
				return false;
			}
			protected set
			{
			}
		}

		public override bool waitForShowAnimation => false;

		public List<GameObject> instantiatedButtons => null;

		protected List<GameObject> instantiatedButtonPool => null;

		protected StandardDialogueUI dialogueUI => null;

		public virtual void Awake()
		{
		}

		public virtual void SetPCPortrait(Sprite portraitSprite, string portraitName)
		{
		}

		[Obsolete("Use SetPCPortrait(Sprite,string) instead.")]
		public virtual void SetPCPortrait(Texture2D portraitTexture, string portraitName)
		{
		}

		public virtual void ShowResponses(Subtitle subtitle, Response[] responses, Transform target)
		{
		}

		protected virtual void ShowResponsesNow(Subtitle subtitle, Response[] responses, Transform target)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckTMProAutoScroll_003Ed__52))]
		protected IEnumerator CheckTMProAutoScroll()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowAfterPanelsClose_003Ed__53))]
		protected virtual IEnumerator ShowAfterPanelsClose(Subtitle subtitle, Response[] responses, Transform target)
		{
			return null;
		}

		public virtual void HideResponses()
		{
		}

		public override void Close()
		{
		}

		public virtual void Focus()
		{
		}

		[IteratorStateMachine(typeof(_003CFocusWhenOpen_003Ed__57))]
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

		protected void ActivateUIElements()
		{
		}

		protected void DeactivateUIElements()
		{
		}

		protected virtual void SetUIElementsActive(bool value)
		{
		}

		public virtual void HideImmediate()
		{
		}

		protected virtual void ClearResponseButtons()
		{
		}

		protected virtual void SetResponseButtons(Response[] responses, Transform target)
		{
		}

		protected virtual void CheckScrollbar()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckScrollbarCoroutine_003Ed__68))]
		protected IEnumerator CheckScrollbarCoroutine()
		{
			return null;
		}

		protected virtual void SetResponseButton(StandardUIResponseButton button, Response response, Transform target, int buttonNumber)
		{
		}

		protected int GetNextAvailableResponseButtonPosition(int start, int direction)
		{
			return 0;
		}

		public virtual void SetupTemplateButtonNavigation(bool hasDisabledButton)
		{
		}

		protected virtual GameObject InstantiateButton()
		{
			return null;
		}

		public void DestroyInstantiatedButtons()
		{
		}

		public virtual void MakeButtonsNonclickable()
		{
		}

		protected void NotifyContentChanged()
		{
		}

		protected void DisableInput()
		{
		}

		protected void EnableInput()
		{
		}

		protected void SetInput(bool value)
		{
		}

		public virtual void StartTimer(float timeout, Action timeoutHandler)
		{
		}

		public virtual void StopTimer()
		{
		}
	}
}
