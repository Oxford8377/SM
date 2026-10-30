using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class DialogueSystemEvents : MonoBehaviour
	{
		[Serializable]
		public class StringEvent : UnityEvent<string>
		{
		}

		[Serializable]
		public class TransformEvent : UnityEvent<Transform>
		{
		}

		[Serializable]
		public class SubtitleEvent : UnityEvent<Subtitle>
		{
		}

		[Serializable]
		public class ResponsesEvent : UnityEvent<Response[]>
		{
		}

		[Serializable]
		public class ConversationEvents
		{
			[Tooltip("Invoked when a conversation starts. Transform is primary actor (typically player).")]
			public TransformEvent onConversationStart;

			[Tooltip("Invoked when a conversation ends. Transform is primary actor (typically player).")]
			public TransformEvent onConversationEnd;

			[Tooltip("Run OnConversationEnd() events at end of frame to allow other scripts to complete their frame processing first.")]
			public bool runOnConversationEndEventsAtEndOfFrame;

			[Tooltip("Invoked when a conversation is cancelled. Transform is primary actor (typically player).")]
			public TransformEvent onConversationCancelled;

			[Tooltip("Invoked just before a line is delivered. Passes Subtitle.")]
			public SubtitleEvent onConversationLine;

			[Tooltip("Invoked when a line has finished. Passes Subtitle.")]
			public SubtitleEvent onConversationLineEnd;

			[Tooltip("Invoked if player presses cancel button while line is being delivered.")]
			public SubtitleEvent onConversationLineCancelled;

			[Tooltip("Invoked when showing a response menu. Passes Response[] array.")]
			public ResponsesEvent onConversationResponseMenu;

			[Tooltip("Invoked when a response menu times out.")]
			public UnityEvent onConversationResponseMenuTimeout;

			[Tooltip("Invoked when a conversation follows a link to another conversation. Transform is primary actor (typically player).")]
			public TransformEvent onLinkedConversationStart;
		}

		[Serializable]
		public class BarkEvents
		{
			[Tooltip("Invoked when a bark starts. Transform is recipient of bark.")]
			public TransformEvent onBarkStart;

			[Tooltip("Invoked when a bark ends. Transform is recipient of bark.")]
			public TransformEvent onBarkEnd;

			[Tooltip("Invoked just before a bark line is delivered. Passes Subtitle.")]
			public SubtitleEvent onBarkLine;
		}

		[Serializable]
		public class SequenceEvents
		{
			[Tooltip("Invoked when a sequence starts. Transform is 'listener' of sequence.")]
			public TransformEvent onSequenceStart;

			[Tooltip("Invoked when a sequence ends. Transform is 'listener' of sequence.")]
			public TransformEvent onSequenceEnd;
		}

		[Serializable]
		public class QuestEvents
		{
			[Tooltip("Invoked when a quest state or quest entry state changes. String is quest title.")]
			public StringEvent onQuestStateChange;

			[Tooltip("Invoked when tracking is enabled for a quest. String is quest title.")]
			public StringEvent onQuestTrackingEnabled;

			[Tooltip("Invoked when tracking is disabled for a quest. String is quest title.")]
			public StringEvent onQuestTrackingDisabled;

			[Tooltip("Invoked when updating quest tracker.")]
			public UnityEvent onUpdateQuestTracker;
		}

		[Serializable]
		public class PauseEvents
		{
			[Tooltip("Invoked when DialogueManager.Pause() is called.")]
			public UnityEvent onDialogueSystemPause;

			[Tooltip("Invoked when DialogueManager.Unpause() is called.")]
			public UnityEvent onDialogueSystemUnpause;
		}

		[CompilerGenerated]
		private sealed class _003CInvokeOnConversationEndAtEndOfFrame_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public DialogueSystemEvents _003C_003E4__this;

			public Transform actor;

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
			public _003CInvokeOnConversationEndAtEndOfFrame_003Ed__17(int _003C_003E1__state)
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

		public ConversationEvents conversationEvents;

		public BarkEvents barkEvents;

		public SequenceEvents sequenceEvents;

		public QuestEvents questEvents;

		public PauseEvents pauseEvents;

		private WaitForEndOfFrame endOfFrame;

		public void OnConversationStart(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		[IteratorStateMachine(typeof(_003CInvokeOnConversationEndAtEndOfFrame_003Ed__17))]
		private IEnumerator InvokeOnConversationEndAtEndOfFrame(Transform actor)
		{
			return null;
		}

		public void OnConversationCancelled(Transform actor)
		{
		}

		public void OnConversationLine(Subtitle subtitle)
		{
		}

		public void OnConversationLineEnd(Subtitle subtitle)
		{
		}

		public void OnConversationLineCancelled(Subtitle subtitle)
		{
		}

		public void OnConversationResponseMenu(Response[] responses)
		{
		}

		public void OnConversationTimeout()
		{
		}

		public void OnLinkedConversationStart(Transform actor)
		{
		}

		public void OnBarkStart(Transform actor)
		{
		}

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnBarkLine(Subtitle subtitle)
		{
		}

		public void OnSequenceStart(Transform actor)
		{
		}

		public void OnSequenceEnd(Transform actor)
		{
		}

		public void OnQuestStateChange(string title)
		{
		}

		public void OnQuestTrackingEnabled(string title)
		{
		}

		public void OnQuestTrackingDisabled(string title)
		{
		}

		public void UpdateTracker()
		{
		}

		public void OnDialogueSystemPause()
		{
		}

		public void OnDialogueSystemUnpause()
		{
		}
	}
}
