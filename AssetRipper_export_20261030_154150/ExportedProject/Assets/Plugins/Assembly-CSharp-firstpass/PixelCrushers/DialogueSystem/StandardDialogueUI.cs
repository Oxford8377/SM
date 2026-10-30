using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardDialogueUI : CanvasDialogueUI, IStandardDialogueUI
	{
		[CompilerGenerated]
		private sealed class _003CCloseAfterPanelsAreClosed_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardDialogueUI _003C_003E4__this;

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
			public _003CCloseAfterPanelsAreClosed_003Ed__28(int _003C_003E1__state)
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
		private sealed class _003CShowSubtitleWhenMainPanelOpen_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardDialogueUI _003C_003E4__this;

			public Subtitle subtitle;

			private StandardUISubtitlePanel _003CfocusedPanel_003E5__2;

			private float _003Ctimeout_003E5__3;

			private bool _003CshowContinueButton_003E5__4;

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
			public _003CShowSubtitleWhenMainPanelOpen_003Ed__36(int _003C_003E1__state)
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
		private sealed class _003CShowResponsesWhenMainPanelOpen_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public StandardDialogueUI _003C_003E4__this;

			public Subtitle subtitle;

			public Response[] responses;

			public float timeout;

			private float _003CwaitForOpenTimeout_003E5__2;

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
			public _003CShowResponsesWhenMainPanelOpen_003Ed__46(int _003C_003E1__state)
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

		public StandardUIAlertControls alertUIElements;

		public StandardUIDialogueControls conversationUIElements;

		public StandardUIQTEControls QTEIndicatorElements;

		[Tooltip("Add an EventSystem if one isn't in the scene.")]
		public bool addEventSystemIfNeeded;

		[Tooltip("Check in Awake if panels are properly assigned. Untick to suppress warnings.")]
		public bool verifyPanelAssignments;

		private Queue<QueuedUIAlert> m_alertQueue;

		private StandardUIRoot m_uiRoot;

		private WaitForEndOfFrame endOfFrame;

		protected Coroutine closeCoroutine;

		protected const float WaitForOpenTimeoutDuration = 8f;

		public override AbstractUIRoot uiRootControls => null;

		public override AbstractUIAlertControls alertControls => null;

		public override AbstractDialogueUIControls dialogueControls => null;

		public override AbstractUIQTEControls qteControls => null;

		protected Queue<QueuedUIAlert> alertQueue => null;

		public override void Awake()
		{
		}

		private void VerifyAssignments()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		protected virtual void CloseNow()
		{
		}

		[IteratorStateMachine(typeof(_003CCloseAfterPanelsAreClosed_003Ed__28))]
		protected IEnumerator CloseAfterPanelsAreClosed()
		{
			return null;
		}

		protected virtual bool IsMainPanelClosed()
		{
			return false;
		}

		public virtual bool AreAnyPanelsClosing(StandardUISubtitlePanel extraSubtitlePanel = null)
		{
			return false;
		}

		public override void Update()
		{
		}

		public override void ShowAlert(string message, float duration)
		{
		}

		private void UpdateAlertQueue()
		{
		}

		private void ShowNextQueuedAlert()
		{
		}

		public override void ShowSubtitle(Subtitle subtitle)
		{
		}

		[IteratorStateMachine(typeof(_003CShowSubtitleWhenMainPanelOpen_003Ed__36))]
		protected virtual IEnumerator ShowSubtitleWhenMainPanelOpen(Subtitle subtitle)
		{
			return null;
		}

		protected virtual void ShowSubtitleImmediate(Subtitle subtitle)
		{
		}

		public override void HideSubtitle(Subtitle subtitle)
		{
		}

		public virtual float GetTypewriterSpeed()
		{
			return 0f;
		}

		public virtual void SetTypewriterSpeed(float charactersPerSecond)
		{
		}

		public virtual void SetActorSubtitlePanelNumber(DialogueActor dialogueActor, SubtitlePanelNumber subtitlePanelNumber)
		{
		}

		public virtual void SetActorMenuPanelNumber(DialogueActor dialogueActor, MenuPanelNumber menuPanelNumber)
		{
		}

		public virtual void OverrideActorPanel(Actor actor, SubtitlePanelNumber subtitlePanelNumber)
		{
		}

		public virtual void ForceOverrideSubtitlePanel(StandardUISubtitlePanel customPanel)
		{
		}

		public override void ShowResponses(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		[IteratorStateMachine(typeof(_003CShowResponsesWhenMainPanelOpen_003Ed__46))]
		protected virtual IEnumerator ShowResponsesWhenMainPanelOpen(Subtitle subtitle, Response[] responses, float timeout)
		{
			return null;
		}

		protected virtual void ShowResponsesImmediate(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		public override void OnClick(object data)
		{
		}

		public virtual void OverrideActorMenuPanel(Transform actorTransform, MenuPanelNumber menuPanelNumber, StandardUIMenuPanel customPanel)
		{
		}

		public virtual void OverrideActorMenuPanel(Actor actor, MenuPanelNumber menuPanelNumber, StandardUIMenuPanel customPanel)
		{
		}

		public virtual void ForceOverrideMenuPanel(StandardUIMenuPanel customPanel)
		{
		}
	}
}
