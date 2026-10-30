using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class BarkOnIdle : BarkStarter
	{
		[CompilerGenerated]
		private sealed class _003CBarkLoop_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BarkOnIdle _003C_003E4__this;

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
			public _003CBarkLoop_003Ed__9(int _003C_003E1__state)
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

		[Tooltip("Minimum seconds between barks.")]
		public float minSeconds;

		[Tooltip("Maximum seconds between barks.")]
		public float maxSeconds;

		[Tooltip("Target to whom bark is addressed. Leave unassigned to just bark into the air.")]
		public Transform target;

		private bool started;

		protected override bool useOnce => false;

		protected override void Start()
		{
		}

		protected override void OnEnable()
		{
		}

		public void StartBarkLoop()
		{
		}

		[IteratorStateMachine(typeof(_003CBarkLoop_003Ed__9))]
		private IEnumerator BarkLoop()
		{
			return null;
		}
	}
}
