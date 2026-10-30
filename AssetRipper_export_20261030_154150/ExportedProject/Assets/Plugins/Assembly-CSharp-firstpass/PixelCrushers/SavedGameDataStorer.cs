using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers
{
	public abstract class SavedGameDataStorer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStoreSavedGameDataAsync_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SavedGameDataStorer _003C_003E4__this;

			public int slotNumber;

			public SavedGameData savedGameData;

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
			public _003CStoreSavedGameDataAsync_003Ed__8(int _003C_003E1__state)
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

		public virtual float progress { get; protected set; }

		public abstract bool HasDataInSlot(int slotNumber);

		public abstract void StoreSavedGameData(int slotNumber, SavedGameData savedGameData);

		public abstract SavedGameData RetrieveSavedGameData(int slotNumber);

		public abstract void DeleteSavedGameData(int slotNumber);

		[IteratorStateMachine(typeof(_003CStoreSavedGameDataAsync_003Ed__8))]
		public virtual IEnumerator StoreSavedGameDataAsync(int slotNumber, SavedGameData savedGameData)
		{
			return null;
		}
	}
}
