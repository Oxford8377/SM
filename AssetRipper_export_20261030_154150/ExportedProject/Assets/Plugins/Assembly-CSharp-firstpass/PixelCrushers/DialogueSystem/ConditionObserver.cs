using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ConditionObserver : MonoBehaviour
	{
		[Serializable]
		public class SendMessageAction
		{
			public GameObject gameObject;

			public string message;

			public string parameter;
		}

		[CompilerGenerated]
		private sealed class _003CObserve_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConditionObserver _003C_003E4__this;

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
			public _003CObserve_003Ed__19(int _003C_003E1__state)
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

		[Tooltip("Frequency in seconds between checks.")]
		public float frequency;

		[Tooltip("When observed condition becomes true, run actions and then deactivate this component.")]
		public bool once;

		[Tooltip("Refer to this GameObject when evaluating the Condition.")]
		public GameObject observeGameObject;

		public Condition condition;

		[Tooltip("Set this quest's state when the condition is true.")]
		public string questName;

		[Tooltip("Set the quest to this state when the condition is true.")]
		[QuestState]
		public QuestState questState;

		[Tooltip("Run this Lua code when the condition is true. Leave blank to skip.")]
		public string luaCode;

		[TextArea(1, 20)]
		[Tooltip("Play this sequence when the condition is true. Leave blank to skip.")]
		public string sequence;

		[Tooltip("Show this alert message when the condition is true. Leave blank to skip.")]
		public string alertMessage;

		[Tooltip("Text table to use to localize alert message.")]
		public TextTable textTable;

		public SendMessageAction[] sendMessages;

		[HideInInspector]
		public bool useQuestNamePicker;

		private bool started;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void StartObserving()
		{
		}

		private void StopObserving()
		{
		}

		[IteratorStateMachine(typeof(_003CObserve_003Ed__19))]
		private IEnumerator Observe()
		{
			return null;
		}

		public void Check()
		{
		}

		public void Check(GameObject gameObject)
		{
		}

		public void Check(string gameObjectName)
		{
		}

		public void Fire()
		{
		}
	}
}
