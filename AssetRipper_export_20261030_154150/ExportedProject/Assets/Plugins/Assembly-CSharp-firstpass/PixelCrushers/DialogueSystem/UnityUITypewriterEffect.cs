using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	public class UnityUITypewriterEffect : AbstractTypewriterEffect
	{
		[Serializable]
		public class AutoScrollSettings
		{
			[Tooltip("Automatically scroll to bottom of scroll rect. Useful for long text. Works best with left justification. Make sure the text has a Content Size Fitter.")]
			public bool autoScrollEnabled;

			public ScrollRect scrollRect;

			[Tooltip("If assigned, the Scrollbar Enabler will be updated with each character to determine if it needs to show the scrollbar.")]
			public UIScrollbarEnabler scrollbarEnabler;

			[Tooltip("If assigned, this should be a copy of the Text component on this typewriter effect. The Sizer Text should have a Content Size Fitter, but the typewriter Text component should not. Make the Sizer Text a parent of the typewriter Text component.")]
			public Text sizerText;
		}

		protected enum TokenType
		{
			Character = 0,
			BoldOpen = 1,
			BoldClose = 2,
			ItalicOpen = 3,
			ItalicClose = 4,
			ColorOpen = 5,
			ColorClose = 6,
			SizeOpen = 7,
			SizeClose = 8,
			Quad = 9,
			Pause = 10,
			InstantOpen = 11,
			InstantClose = 12
		}

		protected class Token
		{
			public TokenType tokenType;

			public char character;

			public string code;

			public float duration;

			public Token(TokenType tokenType, char character, string code, float duration)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityUITypewriterEffect _003C_003E4__this;

			public int fromIndex;

			private float _003Cdelay_003E5__2;

			private float _003ClastTime_003E5__3;

			private float _003Celapsed_003E5__4;

			private int _003CcharactersTyped_003E5__5;

			private int _003CpreTyped_003E5__6;

			private int _003Csafeguard_003E5__7;

			private float _003CdelayTime_003E5__8;

			private int _003CdelaySafeguard_003E5__9;

			private float _003Cgoal_003E5__10;

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
			public _003CPlay_003Ed__41(int _003C_003E1__state)
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
		private sealed class _003CHandleAutoScrollAfterOneFrame_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UnityUITypewriterEffect _003C_003E4__this;

			public bool jumpToEnd;

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
			public _003CHandleAutoScrollAfterOneFrame_003Ed__56(int _003C_003E1__state)
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

		public AutoScrollSettings autoScrollSettings;

		public UnityEvent onBegin;

		public UnityEvent onCharacter;

		public UnityEvent onEnd;

		protected const string RichTextBoldOpen = "<b>";

		protected const string RichTextBoldClose = "</b>";

		protected const string RichTextItalicOpen = "<i>";

		protected const string RichTextItalicClose = "</i>";

		protected const string RichTextColorOpenPrefix = "<color=";

		protected const string RichTextColorClose = "</color>";

		protected const string RichTextSizeOpenPrefix = "<size=";

		protected const string RichTextSizeClose = "</size>";

		protected const string QuadPrefix = "<quad ";

		protected Text control;

		protected bool started;

		protected string original;

		protected string frontSkippedText;

		protected Coroutine typewriterCoroutine;

		protected MonoBehaviour coroutineController;

		protected StringBuilder current;

		protected List<TokenType> openTokenTypes;

		protected List<Token> tokens;

		protected int MaxSafeguard;

		public override bool isPlaying => false;

		public bool IsPlaying => false;

		public override void Awake()
		{
		}

		protected void RemoveIfDuplicate()
		{
		}

		public override void Start()
		{
		}

		public override void OnEnable()
		{
		}

		public override void OnDisable()
		{
		}

		public virtual void Pause()
		{
		}

		public virtual void Unpause()
		{
		}

		public override void StartTyping(string text, int fromIndex = 0)
		{
		}

		public override void StopTyping()
		{
		}

		public virtual void PlayText(string text, int fromIndex = 0)
		{
		}

		protected virtual void StartTypewriterCoroutine(int fromIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CPlay_003Ed__41))]
		public virtual IEnumerator Play(int fromIndex = 0)
		{
			return null;
		}

		protected Token GetNextToken(List<Token> tokens)
		{
			return null;
		}

		protected void OpenRichText(StringBuilder current, Token token, List<TokenType> openTokens)
		{
		}

		protected void CloseRichText(StringBuilder current, Token token, List<TokenType> openTokens)
		{
		}

		protected void AddInstantText(StringBuilder current, List<TokenType> openTokenTypes, List<Token> tokens)
		{
		}

		protected string GetCurrentText(StringBuilder current, List<TokenType> openTokenTypes, List<Token> tokens, bool withoutTransparentText = false)
		{
			return null;
		}

		protected List<Token> Tokenize(string text)
		{
			return null;
		}

		protected Token TryTokenize(string code, TokenType tokenType, float duration, ref string remainder)
		{
			return null;
		}

		protected Token TryTokenizeColorOpen(ref string remainder)
		{
			return null;
		}

		protected Token TryTokenizeSizeOpen(ref string remainder)
		{
			return null;
		}

		protected Token TryTokenizeQuad(ref string remainder)
		{
			return null;
		}

		protected virtual void StopTypewriterCoroutine()
		{
		}

		public override void Stop()
		{
		}

		protected void InitAutoScroll()
		{
		}

		protected void HandleAutoScroll(bool jumpToEnd)
		{
		}

		[IteratorStateMachine(typeof(_003CHandleAutoScrollAfterOneFrame_003Ed__56))]
		protected IEnumerator HandleAutoScrollAfterOneFrame(bool jumpToEnd)
		{
			return null;
		}
	}
}
