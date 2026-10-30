using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[AddComponentMenu(null)]
	public class TypewriterEffect : GUIEffect
	{
		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TypewriterEffect _003C_003E4__this;

			private GUILabel _003Ccontrol_003E5__2;

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
			public _003CPlay_003Ed__6(int _003C_003E1__state)
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

		public float charactersPerSecond;

		public AudioClip audioClip;

		private const string RichTextBoldOpen = "<b>";

		private const string RichTextBoldClose = "</b>";

		private const string RichTextItalicOpen = "<i>";

		private const string RichTextItalicClose = "</i>";

		private const string RichTextColorOpenPrefix = "<color=";

		private const string RichTextColorClose = "</color>";

		public bool IsPlaying { get; private set; }

		[IteratorStateMachine(typeof(_003CPlay_003Ed__6))]
		public override IEnumerator Play()
		{
			return null;
		}

		private void AdvanceOneCharacter(GUILabel control)
		{
		}

		public override void Stop()
		{
		}
	}
}
