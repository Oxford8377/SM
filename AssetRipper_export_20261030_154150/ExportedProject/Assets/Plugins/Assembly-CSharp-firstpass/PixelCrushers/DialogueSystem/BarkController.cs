using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public static class BarkController
	{
		[CompilerGenerated]
		private sealed class _003CBark_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string conversationTitle;

			public Transform speaker;

			public Transform listener;

			public bool stopAtFirstValid;

			public BarkHistory barkHistory;

			public DialogueDatabase database;

			private bool _003Cbarked_003E5__2;

			private IBarkUI _003CbarkUI_003E5__3;

			private Sequencer _003Csequencer_003E5__4;

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
			public _003CBark_003Ed__9(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CBark_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Subtitle subtitle;

			public Transform speaker;

			public Transform listener;

			public IBarkUI barkUI;

			private Sequencer _003Csequencer_003E5__2;

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
			public _003CBark_003Ed__13(int _003C_003E1__state)
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
		private sealed class _003CBark_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Subtitle subtitle;

			public bool skipSequence;

			private Transform _003Cspeaker_003E5__2;

			private Transform _003Clistener_003E5__3;

			private IBarkUI _003CbarkUI_003E5__4;

			private Sequencer _003Csequencer_003E5__5;

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
			public _003CBark_003Ed__14(int _003C_003E1__state)
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

		private static Dictionary<Transform, int> currentBarkPriority;

		public static Sequencer LastSequencer { get; private set; }

		static BarkController()
		{
		}

		private static int GetSpeakerCurrentBarkPriority(Transform speaker)
		{
			return 0;
		}

		private static void SetSpeakerCurrentBarkPriority(Transform speaker, int priority)
		{
		}

		private static int GetEntryBarkPriority(DialogueEntry entry)
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CBark_003Ed__9))]
		public static IEnumerator Bark(string conversationTitle, Transform speaker, Transform listener, BarkHistory barkHistory, DialogueDatabase database = null, bool stopAtFirstValid = false)
		{
			return null;
		}

		private static void CheckCancelPreviousBarkSequence(Transform speaker, IBarkUI barkUI)
		{
		}

		private static Sequencer PlayBarkSequence(Subtitle subtitle, Transform speaker, Transform listener)
		{
			return null;
		}

		private static Sequencer PlayBarkSequence(string barkText, string sequence, string entrytag, Transform speaker, Transform listener)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBark_003Ed__13))]
		public static IEnumerator Bark(Subtitle subtitle, Transform speaker, Transform listener, IBarkUI barkUI)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CBark_003Ed__14))]
		public static IEnumerator Bark(Subtitle subtitle, bool skipSequence = false)
		{
			return null;
		}

		private static bool CheckDontBarkDuringConversation()
		{
			return false;
		}

		private static void InformParticipants(string message, Transform speaker, Transform listener)
		{
		}

		private static void InformParticipantsLine(string message, Transform speaker, Subtitle subtitle)
		{
		}
	}
}
