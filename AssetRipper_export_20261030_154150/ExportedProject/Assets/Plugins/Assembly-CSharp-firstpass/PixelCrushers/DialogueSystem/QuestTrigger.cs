using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class QuestTrigger : DialogueEventStarter
	{
		[Serializable]
		public class SendMessageAction
		{
			public GameObject gameObject;

			public string message;

			public string parameter;
		}

		[CompilerGenerated]
		private sealed class _003CStartAfterOneFrame_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public QuestTrigger _003C_003E4__this;

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
			public _003CStartAfterOneFrame_003Ed__33(int _003C_003E1__state)
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

		[DialogueTriggerEvent]
		public DialogueTriggerEvent trigger;

		public Condition condition;

		public string questName;

		[Tooltip("Set the main state of the quest.")]
		public bool setQuestState;

		[QuestState]
		public QuestState questState;

		[Tooltip("Set the state of a quest entry (subtask) in the quest.")]
		public bool setQuestEntryState;

		[Tooltip("Quest entry number whose state to change.")]
		public int questEntryNumber;

		[QuestState]
		public QuestState questEntryState;

		[Tooltip("(Optional) Run this Lua code after setting the quest state.")]
		public string luaCode;

		[Tooltip("(Optional) Show this alert message after setting the quest state.")]
		public string alertMessage;

		[Tooltip("Localized text table to use for the alert message.")]
		public LocalizedTextTable localizedTextTable;

		public SendMessageAction[] sendMessages;

		[HideInInspector]
		public bool useQuestNamePicker;

		[HideInInspector]
		public DialogueDatabase selectedDatabase;

		private bool tryingToStart;

		private bool listenForOnDestroy;

		public void OnBarkEnd(Transform actor)
		{
		}

		public void OnConversationEnd(Transform actor)
		{
		}

		public void OnSequenceEnd(Transform actor)
		{
		}

		public void OnUse(Transform actor)
		{
		}

		public void OnUse(string message)
		{
		}

		public void OnUse()
		{
		}

		public void OnTriggerEnter(Collider other)
		{
		}

		public void OnTriggerExit(Collider other)
		{
		}

		public void OnCollisionEnter(Collision collision)
		{
		}

		public void OnCollisionExit(Collision collision)
		{
		}

		public void Start()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}

		public void OnLevelWillBeUnloaded()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public void OnDestroy()
		{
		}

		[IteratorStateMachine(typeof(_003CStartAfterOneFrame_003Ed__33))]
		private IEnumerator StartAfterOneFrame()
		{
			return null;
		}

		public void TryStart(Transform actor)
		{
		}

		public void Fire()
		{
		}
	}
}
