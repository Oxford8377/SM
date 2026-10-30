using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[DisallowMultipleComponent]
	[AddComponentMenu(null)]
	public class TextMeshProTypewriterEffect : AbstractTypewriterEffect
	{
		[Serializable]
		public class AutoScrollSettings
		{
			[Tooltip("Automatically scroll to bottom of scroll rect. Useful for long text. Works best with left justification.")]
			public bool autoScrollEnabled;

			public ScrollRect scrollRect;

			[Tooltip("Optional. Add a UIScrollBarEnabler to main dialogue panel, assign UI elements, then assign it here to automatically enable scrollbar if content is taller than viewport.")]
			public UIScrollbarEnabler scrollbarEnabler;
		}

		protected enum RPGMakerTokenType
		{
			None = 0,
			QuarterPause = 1,
			FullPause = 2,
			SkipToEnd = 3,
			InstantOpen = 4,
			InstantClose = 5
		}

		[CompilerGenerated]
		private sealed class _003CPlay_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TextMeshProTypewriterEffect _003C_003E4__this;

			public int fromIndex;

			private float _003Cdelay_003E5__2;

			private float _003ClastTime_003E5__3;

			private float _003Celapsed_003E5__4;

			private string _003CparsedText_003E5__5;

			private int _003CtotalVisibleCharacters_003E5__6;

			private int _003CskippedCharacters_003E5__7;

			private float _003CdelayTime_003E5__8;

			private int _003CdelaySafeguard_003E5__9;

			private float _003Cgoal_003E5__10;

			private List<RPGMakerTokenType> _003Ctokens_003E5__11;

			private int _003Ci_003E5__12;

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
			public _003CPlay_003Ed__40(int _003C_003E1__state)
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

		protected const string RPGMakerCodeQuarterPause = "\\,";

		protected const string RPGMakerCodeFullPause = "\\.";

		protected const string RPGMakerCodeSkipToEnd = "\\^";

		protected const string RPGMakerCodeInstantOpen = "\\>";

		protected const string RPGMakerCodeInstantClose = "\\<";

		protected Dictionary<int, List<RPGMakerTokenType>> rpgMakerTokens;

		protected TMP_Text m_textComponent;

		protected LayoutElement m_layoutElement;

		protected bool started;

		protected int charactersTyped;

		protected Coroutine typewriterCoroutine;

		protected MonoBehaviour coroutineController;

		public override bool isPlaying => false;

		public bool IsPlaying => false;

		protected TMP_Text textComponent => null;

		protected LayoutElement layoutElement => null;

		protected AudioSource runtimeAudioSource => null;

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

		public void Pause()
		{
		}

		public void Unpause()
		{
		}

		public void Rewind()
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

		[IteratorStateMachine(typeof(_003CPlay_003Ed__40))]
		public virtual IEnumerator Play(int fromIndex)
		{
			return null;
		}

		protected void ProcessRPGMakerCodes()
		{
		}

		protected bool PeelRPGMakerTokenFromFront(ref string source, out RPGMakerTokenType token)
		{
			token = default(RPGMakerTokenType);
			return false;
		}

		protected void StopTypewriterCoroutine()
		{
		}

		public override void Stop()
		{
		}

		protected virtual void HandleAutoScroll()
		{
		}

		public void FindYourVoice()
		{
		}
	}
}
