using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class UnityUIDialogueUI : CanvasDialogueUI
	{
		private class QueuedAlert
		{
			public string message;

			public float duration;

			public QueuedAlert(string message, float duration)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowResponsesAfterHidden_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityUIDialogueUI _003C_003E4__this;

			public Subtitle subtitle;

			public Response[] responses;

			public float timeout;

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
			public _003CShowResponsesAfterHidden_003Ed__45(int _003C_003E1__state)
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

		[HideInInspector]
		public UnityUIRoot unityUIRoot;

		public UnityUIDialogueControls dialogue;

		public Graphic[] qteIndicators;

		public UnityUIAlertControls alert;

		[Tooltip("Always keep a control focused; useful for gamepads and keyboard.")]
		public bool autoFocus;

		[Tooltip("Allow the dialogue UI to steal focus if a non-dialogue UI panel has it.")]
		public bool allowStealFocus;

		[Tooltip("If auto focusing, check on this frequency in seconds that the control is focused.")]
		public float autoFocusCheckFrequency;

		[Tooltip("Look for OverrideUnityUIDialogueControls on actors.")]
		public bool findActorOverrides;

		[Tooltip("Add an EventSystem if one isn't in the scene.")]
		public bool addEventSystemIfNeeded;

		private UnityUIQTEControls m_qteControls;

		private float m_nextAutoFocusCheckTime;

		private GameObject m_lastSelection;

		private Queue<QueuedAlert> alertQueue;

		protected UnityUISubtitleControls originalNPCSubtitle;

		protected UnityUISubtitleControls originalPCSubtitle;

		protected UnityUIResponseMenuControls originalResponseMenu;

		private Dictionary<Transform, OverrideUnityUIDialogueControls> overrideCache;

		private bool isShowingNpcSubtitle;

		private bool isShowingPcSubtitle;

		private bool isShowingResponses;

		protected int alertQueueCount;

		protected bool alertIsVisible;

		protected bool alertIsHiding;

		public override AbstractUIRoot uiRootControls => null;

		public override AbstractDialogueUIControls dialogueControls => null;

		public override AbstractUIQTEControls qteControls => null;

		public override AbstractUIAlertControls alertControls => null;

		public override void Awake()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		private void FindControls()
		{
		}

		public OverrideUnityUIDialogueControls FindActorOverride(Transform actor)
		{
			return null;
		}

		public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public override void Open()
		{
		}

		public override void ShowAlert(string message, float duration)
		{
		}

		private void ShowNextQueuedAlert()
		{
		}

		private void StartShowingAlert(string message, float duration)
		{
		}

		public override void ShowSubtitle(Subtitle subtitle)
		{
		}

		protected void CheckForSupercededSubtitle(CharacterType characterType)
		{
		}

		public void CheckSubtitleAutoFocus(Subtitle subtitle)
		{
		}

		protected void SetIsShowingSubtitle(Subtitle subtitle, bool value)
		{
		}

		public override void HideSubtitle(Subtitle subtitle)
		{
		}

		public override void ShowResponses(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		[IteratorStateMachine(typeof(_003CShowResponsesAfterHidden_003Ed__45))]
		private IEnumerator ShowResponsesAfterHidden(Subtitle subtitle, Response[] responses, float timeout)
		{
			return null;
		}

		public void CheckResponseMenuAutoFocus()
		{
		}

		public override void HideResponses()
		{
		}

		public void ClearSelection()
		{
		}

		public override void Update()
		{
		}
	}
}
