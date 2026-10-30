using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class SetEnabledOnDialogueEvent : ActOnDialogueEvent
	{
		[Serializable]
		public class SetEnabledAction : Action
		{
			public MonoBehaviour target;

			public Toggle state;
		}

		[CompilerGenerated]
		private sealed class _003CTryActionsAfterOneFrameCoroutine_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SetEnabledOnDialogueEvent _003C_003E4__this;

			public SetEnabledAction[] actions;

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
			public _003CTryActionsAfterOneFrameCoroutine_003Ed__9(int _003C_003E1__state)
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

		public SetEnabledAction[] onStart;

		[Tooltip("When the dialogue event starts, wait one frame before processing the On Start list.")]
		public bool waitOneFrameOnStart;

		public SetEnabledAction[] onEnd;

		[Tooltip("When the dialogue event starts, wait one frame before processing the On End list.")]
		public bool waitOneFrameOnEnd;

		public override void TryStartActions(Transform actor)
		{
		}

		public override void TryEndActions(Transform actor)
		{
		}

		private void TryActions(SetEnabledAction[] actions, Transform actor, bool waitOneFrame)
		{
		}

		private void TryActionsNow(SetEnabledAction[] actions, Transform actor)
		{
		}

		[IteratorStateMachine(typeof(_003CTryActionsAfterOneFrameCoroutine_003Ed__9))]
		private IEnumerator TryActionsAfterOneFrameCoroutine(SetEnabledAction[] actions, Transform actor)
		{
			return null;
		}

		public void DoAction(SetEnabledAction action, Transform actor)
		{
		}
	}
}
