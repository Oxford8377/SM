using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ExtraDatabases : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CAddDatabasesCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ExtraDatabases _003C_003E4__this;

			private DialogueDatabase[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

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
			public _003CAddDatabasesCoroutine_003Ed__18(int _003C_003E1__state)
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
		private sealed class _003CRemoveDatabasesCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ExtraDatabases _003C_003E4__this;

			private DialogueDatabase[] _003C_003E7__wrap1;

			private int _003C_003E7__wrap2;

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
			public _003CRemoveDatabasesCoroutine_003Ed__23(int _003C_003E1__state)
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
		private sealed class _003CDestroyCoroutine_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ExtraDatabases _003C_003E4__this;

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
			public _003CDestroyCoroutine_003Ed__25(int _003C_003E1__state)
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
		private sealed class _003CStartEndOfFrame_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ExtraDatabases _003C_003E4__this;

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
			public _003CStartEndOfFrame_003Ed__27(int _003C_003E1__state)
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

		public DialogueTriggerEvent addTrigger;

		public DialogueTriggerEvent removeTrigger;

		public DialogueDatabase[] databases;

		public Condition condition;

		[Tooltip("As soon as one event (add or remove) has occurred, destroy this component.")]
		public bool once;

		[Tooltip("Add/remove one database per frame instead of adding them all at the same time. Useful to avoid stutter when adding several databases.")]
		public bool onePerFrame;

		protected bool m_trying;

		protected Coroutine m_destroyCoroutine;

		protected int m_numActiveCoroutines;

		public static event Action addedDatabases
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action removedDatabases
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected virtual void TryAddDatabases(Transform interactor, bool onePerFrame)
		{
		}

		public virtual void AddDatabases(bool onePerFrame)
		{
		}

		protected virtual void AddDatabasesImmediate()
		{
		}

		[IteratorStateMachine(typeof(_003CAddDatabasesCoroutine_003Ed__18))]
		protected virtual IEnumerator AddDatabasesCoroutine()
		{
			return null;
		}

		protected virtual void AddDatabase(DialogueDatabase database)
		{
		}

		protected virtual void TryRemoveDatabases(Transform interactor, bool onePerFrame)
		{
		}

		public virtual void RemoveDatabases(bool onePerFrame)
		{
		}

		protected virtual void RemoveDatabasesImmediate()
		{
		}

		[IteratorStateMachine(typeof(_003CRemoveDatabasesCoroutine_003Ed__23))]
		protected virtual IEnumerator RemoveDatabasesCoroutine()
		{
			return null;
		}

		protected virtual void RemoveDatabase(DialogueDatabase database)
		{
		}

		[IteratorStateMachine(typeof(_003CDestroyCoroutine_003Ed__25))]
		protected virtual IEnumerator DestroyCoroutine()
		{
			return null;
		}

		public virtual void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CStartEndOfFrame_003Ed__27))]
		protected virtual IEnumerator StartEndOfFrame()
		{
			return null;
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void OnDestroy()
		{
		}

		public virtual void OnUse(Transform actor)
		{
		}

		public virtual void OnUse(string message)
		{
		}

		public virtual void OnUse()
		{
		}

		public virtual void OnTriggerEnter(Collider other)
		{
		}

		public virtual void OnTriggerExit(Collider other)
		{
		}
	}
}
