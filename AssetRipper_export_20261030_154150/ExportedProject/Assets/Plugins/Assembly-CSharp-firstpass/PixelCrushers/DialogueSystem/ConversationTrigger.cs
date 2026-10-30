using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ConversationTrigger : ConversationStarter
	{
		[CompilerGenerated]
		private sealed class _003CStartConversationAfterOneFrame_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConversationTrigger _003C_003E4__this;

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
			public _003CStartConversationAfterOneFrame_003Ed__24(int _003C_003E1__state)
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

		[Tooltip("The primary actor (e.g., player). If unassigned, the GameObject that triggered the conversation.")]
		public Transform actor;

		[Tooltip("Try to start the conversation when this event occurs.")]
		[DialogueTriggerEvent]
		public DialogueTriggerEvent trigger;

		[Tooltip("Stop the triggered conversation if this GameObject receives OnTriggerExit.")]
		public bool stopConversationOnTriggerExit;

		private float earliestTimeToAllowTriggerExit;

		private const float MarginToAllowTriggerExit = 0.2f;

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

		private void TryStartConversationOnTriggerEnter(Transform otherTransform)
		{
		}

		private void CheckOnTriggerExit(Transform otherTransform)
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

		[IteratorStateMachine(typeof(_003CStartConversationAfterOneFrame_003Ed__24))]
		private IEnumerator StartConversationAfterOneFrame()
		{
			return null;
		}
	}
}
