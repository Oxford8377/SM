using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ConversationStateSaver : Saver
	{
		[Serializable]
		public class Data
		{
			public int conversationID;

			public int entryID;

			public string actorName;

			public string conversantName;

			public List<string> actorGOs;

			public List<SubtitlePanelNumber> actorGOPanels;

			public List<int> actorIDs;

			public List<SubtitlePanelNumber> actorIDPanels;
		}

		[CompilerGenerated]
		private sealed class _003CStartSavedConversation_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Data data;

			public ConversationStateSaver _003C_003E4__this;

			private StandardDialogueUI _003CdialogueUI_003E5__2;

			private float _003CsafeguardTimeout_003E5__3;

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
			public _003CStartSavedConversation_003Ed__6(int _003C_003E1__state)
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

		public override string key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string s)
		{
		}

		[IteratorStateMachine(typeof(_003CStartSavedConversation_003Ed__6))]
		protected IEnumerator StartSavedConversation(Data data)
		{
			return null;
		}
	}
}
