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
	public class SMSDialogueUI : StandardDialogueUI
	{
		[Serializable]
		public class PreDelaySettings
		{
			[Tooltip("Show this when waiting before showing subtitle. Often a '...' image suggesting NPC is typing.")]
			public GameObject preDelayIcon;

			[Tooltip("Before showing subtitle, delay based on the Dialogue Text length and Dialogue Manager > Subtitle Settings > Subtitle Chars Per Second.")]
			public bool basedOnTextLength;

			[Tooltip("Before showing subtitle, also delay for this many seconds.")]
			public float additionalSeconds;

			public float GetDelayDuration(Subtitle subtitle)
			{
				return 0f;
			}

			public void CopyTo(PreDelaySettings dest)
			{
			}
		}

		[Serializable]
		public class DialogueEntryRecord
		{
			public int conversationID;

			public int entryID;

			public DialogueEntryRecord(int conversationID, int entryID)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowResponsesAfterPreDelay_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SMSDialogueUI _003C_003E4__this;

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
			public _003CShowResponsesAfterPreDelay_003Ed__36(int _003C_003E1__state)
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
		private sealed class _003CAddMessageWithPreDelay_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SMSDialogueUI _003C_003E4__this;

			public Subtitle subtitle;

			public float preDelay;

			private GameObject _003CpreDelayIcon_003E5__2;

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
			public _003CAddMessageWithPreDelay_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CScrollToBottomCoroutine_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SMSDialogueUI _003C_003E4__this;

			private float _003Cratio_003E5__2;

			private float _003Ctimeout_003E5__3;

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
			public _003CScrollToBottomCoroutine_003Ed__47(int _003C_003E1__state)
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

		[Header("Heading")]
		[Tooltip("(Optional) If assigned, set to the conversation title.")]
		public Text headingText;

		[Tooltip("The scroll rect containing the content panel.")]
		[Header("Message Panel")]
		public ScrollRect scrollRect;

		[Tooltip("The content panel inside the scroll rect containing the message panel and response panel.")]
		public RectTransform contentPanel;

		[Tooltip("Add messages to this panel.")]
		public RectTransform messagePanel;

		[Tooltip("If non-zero, drop older messages when the number of messages in the history reaches this value.")]
		public int maxMessages;

		[Tooltip("Speed at which to smoothly scroll down.")]
		public float scrollSpeed;

		[Tooltip("Before showing NPC subtitles, delay for this duration.")]
		public PreDelaySettings npcPreDelaySettings;

		[Tooltip("Before showing PC subtitles, delay for this duration.")]
		public PreDelaySettings pcPreDelaySettings;

		[Header("Save/Load")]
		[Tooltip("Load the saved conversation specified in the Conversation variable.")]
		public bool useConversationVariable;

		[Tooltip("When resuming conversation, don't play sequence of last entry.")]
		public bool dontRepeatLastSequence;

		[Tooltip("Disable Audio() and AudioWait() sequencer commands when resuming last entry.")]
		public bool disableAudioOnLastSequence;

		[Tooltip("When entering these scene(s), don't resume the conversation. Typically used for the start menu (scene 0).")]
		public int[] dontLoadConversationInScenes;

		public static string conversationVariableOverride;

		protected List<DialogueEntryRecord> records;

		protected List<GameObject> instantiatedMessages;

		protected int currentSceneIndex;

		protected PreDelaySettings npcPreDelaySettingsCopy;

		protected PreDelaySettings pcPreDelaySettingsCopy;

		protected bool isLoadingGame;

		protected bool skipNextRecord;

		protected bool isInPreDelay;

		protected Coroutine scrollCoroutine;

		protected bool shouldShowContinueButton;

		protected Button continueButton;

		protected Dictionary<Transform, DialogueActor> dialogueActorCache;

		public string conversationVariableValue => null;

		public string currentConversationActor => null;

		public string currentConversationConversant => null;

		public string currentDialogueEntryRecords => null;

		protected virtual void CheckAssignments()
		{
		}

		public override void OnEnable()
		{
		}

		public override void OnDisable()
		{
		}

		protected void RecordCurrentScene(Scene scene, LoadSceneMode mode)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		public override void ShowSubtitle(Subtitle subtitle)
		{
		}

		public override void HideSubtitle(Subtitle subtitle)
		{
		}

		public override void ShowResponses(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		[IteratorStateMachine(typeof(_003CShowResponsesAfterPreDelay_003Ed__36))]
		protected IEnumerator ShowResponsesAfterPreDelay(Subtitle subtitle, Response[] responses, float timeout)
		{
			return null;
		}

		protected virtual void ShowResponsesNow(Subtitle subtitle, Response[] responses, float timeout)
		{
		}

		protected virtual DialogueActor GetDialogueActor(Subtitle subtitle)
		{
			return null;
		}

		protected virtual StandardUISubtitlePanel GetTemplate(Subtitle subtitle, DialogueActor dialogueActor)
		{
			return null;
		}

		protected virtual StandardUISubtitlePanel GetTemplate(Subtitle subtitle)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CAddMessageWithPreDelay_003Ed__41))]
		protected virtual IEnumerator AddMessageWithPreDelay(float preDelay, Subtitle subtitle)
		{
			return null;
		}

		protected virtual void AddMessage(Subtitle subtitle)
		{
		}

		public override void ShowContinueButton(Subtitle subtitle)
		{
		}

		public override void OnContinueConversation()
		{
		}

		protected virtual T FindUIElement<T>(Transform t, string name1, string name2) where T : MonoBehaviour
		{
			return null;
		}

		protected virtual void ScrollToBottom()
		{
		}

		[IteratorStateMachine(typeof(_003CScrollToBottomCoroutine_003Ed__47))]
		protected virtual IEnumerator ScrollToBottomCoroutine()
		{
			return null;
		}

		protected virtual void AddRecord(Subtitle subtitle)
		{
		}

		public virtual void ClearContent()
		{
		}

		protected virtual void DestroyInstantiatedMessages()
		{
		}

		protected virtual bool DontLoadInThisScene()
		{
			return false;
		}

		public virtual void OnRecordPersistentData()
		{
		}

		public virtual void OnApplyPersistentData()
		{
		}

		public void ClearRecords()
		{
		}

		public virtual void SaveConversation()
		{
		}

		public virtual void ResumeConversation(string conversation = null)
		{
		}
	}
}
