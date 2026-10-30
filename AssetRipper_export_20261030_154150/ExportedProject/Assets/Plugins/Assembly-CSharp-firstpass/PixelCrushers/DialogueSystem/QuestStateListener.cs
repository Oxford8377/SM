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
	public class QuestStateListener : MonoBehaviour
	{
		[Serializable]
		public class QuestStateIndicatorLevel
		{
			[Tooltip("Quest state to listen for.")]
			public QuestState questState;

			[Tooltip("Conditions that must also be true.")]
			public Condition condition;

			[Tooltip("Indicator level to use when this quest state is reached.")]
			public int indicatorLevel;

			public UnityEvent onEnterState;
		}

		[Serializable]
		public class QuestEntryStateIndicatorLevel
		{
			[Tooltip("Quest entry number.")]
			public int entryNumber;

			[Tooltip("Quest entry state to listen for.")]
			public QuestState questState;

			[Tooltip("Conditions that must also be true.")]
			public Condition condition;

			[Tooltip("Indicator level to use when this quest state is reached.")]
			public int indicatorLevel;

			public UnityEvent onEnterState;
		}

		[CompilerGenerated]
		private sealed class _003CStart_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public QuestStateListener _003C_003E4__this;

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
			public _003CStart_003Ed__18(int _003C_003E1__state)
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

		[QuestPopup(true)]
		public string questName;

		public QuestStateIndicatorLevel[] questStateIndicatorLevels;

		public QuestEntryStateIndicatorLevel[] questEntryStateIndicatorLevels;

		[Tooltip("When starting component, do not invoke any OnEnterState() events.")]
		public bool suppressOnEnterStateEventsOnStart;

		protected QuestStateDispatcher m_questStateDispatcher;

		protected QuestStateIndicator m_questStateIndicator;

		private bool m_started;

		protected bool m_suppressOnEnterStateEvent;

		protected QuestStateDispatcher questStateDispatcher => null;

		protected QuestStateIndicator questStateIndicator => null;

		protected bool started
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void OnApplicationQuit()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__18))]
		protected virtual IEnumerator Start()
		{
			return null;
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void OnChange()
		{
		}

		public virtual void UpdateIndicator()
		{
		}
	}
}
