using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class UIScrollbarEnabler : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckScrollbarAfterUIUpdate_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UIScrollbarEnabler _003C_003E4__this;

			public bool useResetValue;

			public float resetValue;

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
			public _003CCheckScrollbarAfterUIUpdate_003Ed__13(int _003C_003E1__state)
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

		[Tooltip("The scroll rect.")]
		[FormerlySerializedAs("container")]
		public ScrollRect scrollRect;

		[Tooltip("The content inside the scroll rect. The scrollbar will be enabled if the content is taller than the scroll rect.")]
		[FormerlySerializedAs("content")]
		public RectTransform scrollContent;

		[Tooltip("The scrollbar to enable or disable. If scroll rect doesn't have a scrollbar, just scrolls scroll rect.")]
		public Scrollbar scrollbar;

		[Tooltip("Scroll smoothly instead of jumping to reset value.")]
		public bool smoothScroll;

		public float smoothScrollSpeed;

		protected bool m_started;

		protected bool m_checking;

		protected RectTransform m_scrollRectTransform;

		protected virtual void Start()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void CheckScrollbar()
		{
		}

		public virtual void CheckScrollbarWithResetValue(float value)
		{
		}

		[IteratorStateMachine(typeof(_003CCheckScrollbarAfterUIUpdate_003Ed__13))]
		protected virtual IEnumerator CheckScrollbarAfterUIUpdate(bool useResetValue, float resetValue)
		{
			return null;
		}
	}
}
