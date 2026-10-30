using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[AddComponentMenu(null)]
	public class UnityBarkUIOnGUI : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CFadeOut_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float fadeDuration;

			public UnityBarkUIOnGUI _003C_003E4__this;

			private float _003CstartTime_003E5__2;

			private float _003CendTime_003E5__3;

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
			public _003CFadeOut_003Ed__26(int _003C_003E1__state)
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

		public Vector3 offset;

		public float maxWidth;

		protected GUISkin guiSkin;

		protected string guiStyleName;

		protected GUIStyle guiStyle;

		protected FormattedText formattingToApply;

		protected TextStyle textStyle;

		protected Color textStyleColor;

		protected Vector2 size;

		protected string message;

		protected float alpha;

		protected Transform myTransform;

		protected Transform absolutePosition;

		protected Vector3 offsetToHead;

		protected Vector3 screenPos;

		public bool IsPlaying => false;

		public Vector3 BarkPosition { get; private set; }

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		protected void ComputeOffsetToHead()
		{
		}

		public virtual void Show(Subtitle subtitle, float duration, GUISkin guiSkin, string guiStyleName, TextStyle textStyle, bool includeName, Transform textPosition)
		{
		}

		public virtual void Show(Subtitle subtitle, float duration, GUISkin guiSkin, string guiStyleName, TextStyle textStyle, Color textStyleColor, bool includeName, Transform textPosition)
		{
		}

		[IteratorStateMachine(typeof(_003CFadeOut_003Ed__26))]
		public IEnumerator FadeOut(float fadeDuration)
		{
			return null;
		}

		public virtual void OnGUI()
		{
		}

		protected void UpdateBarkPosition()
		{
		}
	}
}
