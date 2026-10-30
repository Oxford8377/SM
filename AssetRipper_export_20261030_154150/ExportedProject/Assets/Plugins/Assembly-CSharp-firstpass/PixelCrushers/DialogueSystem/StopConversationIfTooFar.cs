using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StopConversationIfTooFar : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CMonitorDistance_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Transform actor;

			public StopConversationIfTooFar _003C_003E4__this;

			private Transform _003CmyTransform_003E5__2;

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
			public _003CMonitorDistance_003Ed__5(int _003C_003E1__state)
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

		public float maxDistance;

		public float monitorFrequency;

		private void OnConversationStart(Transform actor)
		{
		}

		private void OnConversationEnd(Transform actor)
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CMonitorDistance_003Ed__5))]
		private IEnumerator MonitorDistance(Transform actor)
		{
			return null;
		}
	}
}
