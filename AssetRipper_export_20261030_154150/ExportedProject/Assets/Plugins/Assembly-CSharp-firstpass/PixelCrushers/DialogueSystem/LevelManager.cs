using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class LevelManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CLoadLevelFromSaveData_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LevelManager _003C_003E4__this;

			public string saveData;

			private string _003ClevelName_003E5__2;

			private AsyncOperation _003Casync_003E5__3;

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
			public _003CLoadLevelFromSaveData_003Ed__14(int _003C_003E1__state)
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
		private sealed class _003CLoadLevelCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LevelManager _003C_003E4__this;

			public string levelName;

			public int levelIndex;

			private AsyncOperation _003Casync_003E5__2;

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
			public _003CLoadLevelCoroutine_003Ed__17(int _003C_003E1__state)
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

		[Tooltip("Level to use if none is recorded in saved-game data.")]
		public string defaultStartingLevel;

		[Tooltip("Load asynchronously to prevent freeze while loading.")]
		public bool useAsyncLoad;

		public bool isLoading { get; private set; }

		public bool IsLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void LoadGame(string saveData)
		{
		}

		public void RestartGame()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadLevelFromSaveData_003Ed__14))]
		private IEnumerator LoadLevelFromSaveData(string saveData)
		{
			return null;
		}

		public void LoadLevel(string levelName)
		{
		}

		public void LoadLevel(int levelIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadLevelCoroutine_003Ed__17))]
		private IEnumerator LoadLevelCoroutine(string levelName, int levelIndex)
		{
			return null;
		}

		private bool CanLoadAsync()
		{
			return false;
		}

		public virtual void OnRecordPersistentData()
		{
		}
	}
}
