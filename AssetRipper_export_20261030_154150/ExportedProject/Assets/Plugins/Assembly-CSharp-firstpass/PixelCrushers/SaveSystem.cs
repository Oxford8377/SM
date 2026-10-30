using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class SaveSystem : MonoBehaviour
	{
		public delegate string ValidateSceneNameDelegate(string sceneName, SceneValidationMode sceneValidationMode);

		public delegate void SceneLoadedDelegate(string sceneName, int sceneIndex);

		[CompilerGenerated]
		private sealed class _003CLoadSceneInternal_003Ed__90 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string sceneName;

			public SceneValidationMode sceneValidationMode;

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
			public _003CLoadSceneInternal_003Ed__90(int _003C_003E1__state)
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
		private sealed class _003CLoadSceneInternalTransitionCoroutine_003Ed__91 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string sceneName;

			public SceneValidationMode sceneValidationMode;

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
			public _003CLoadSceneInternalTransitionCoroutine_003Ed__91(int _003C_003E1__state)
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
		private sealed class _003CLoadAdditiveSceneInternal_003Ed__92 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string sceneName;

			public SceneValidationMode sceneValidationMode;

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
			public _003CLoadAdditiveSceneInternal_003Ed__92(int _003C_003E1__state)
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
		private sealed class _003CSaveToSlotCoroutine_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int slotNumber;

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
			public _003CSaveToSlotCoroutine_003Ed__103(int _003C_003E1__state)
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
		private sealed class _003CLoadFromSlotCoroutine_003Ed__106 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int slotNumber;

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
			public _003CLoadFromSlotCoroutine_003Ed__106(int _003C_003E1__state)
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
		private sealed class _003CDelayedSaveDataAppliedCoroutine_003Ed__116 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int frames;

			private int _003Ci_003E5__2;

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
			public _003CDelayedSaveDataAppliedCoroutine_003Ed__116(int _003C_003E1__state)
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
		private sealed class _003CLoadSceneCoroutine_003Ed__121 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SavedGameData savedGameData;

			public string spawnpointName;

			public SceneValidationMode sceneValidationMode;

			private int _003Ci_003E5__2;

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
			public _003CLoadSceneCoroutine_003Ed__121(int _003C_003E1__state)
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

		public const int NoSceneIndex = -1;

		public const string LastSavedGameSlotPlayerPrefsKey = "savedgame_lastSlotNum";

		[SerializeField]
		[Tooltip("Optional saved game version number of your choosing. Version number is included in saved game files.")]
		private int m_version;

		[SerializeField]
		[Tooltip("When loading a game, load the scene that the game was saved in.")]
		private bool m_saveCurrentScene;

		[Tooltip("When loading a game/scene, wait this many frames before applying saved data to allow other scripts to initialize first.")]
		[SerializeField]
		private int m_framesToWaitBeforeApplyData;

		[Tooltip("Log debug info.")]
		[SerializeField]
		private bool m_debug;

		private bool m_isLoadingAdditiveScene;

		private static SaveSystem m_instance;

		private static HashSet<Saver> m_savers;

		private static List<Saver> m_tmpSavers;

		private static SavedGameData m_savedGameData;

		private static DataSerializer m_serializer;

		private static SavedGameDataStorer m_storer;

		private static SceneTransitionManager m_sceneTransitionManager;

		private static GameObject m_playerSpawnpoint;

		private static int m_currentSceneIndex;

		private static List<string> m_addedScenes;

		private static bool m_autoUnloadAdditiveScenes;

		private static AsyncOperation m_currentAsyncOperation;

		private static int m_framesToWaitBeforeSaveDataAppliedEvent;

		private static bool m_isQuitting;

		public static ValidateSceneNameDelegate validateNameScene;

		public static int version
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool saveCurrentScene
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static int framesToWaitBeforeApplyData
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static int framesToWaitBeforeSaveDataAppliedEvent
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static bool debug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool hasInstance => false;

		public static SaveSystem instance => null;

		public static DataSerializer serializer => null;

		public static SavedGameDataStorer storer => null;

		public static SceneTransitionManager sceneTransitionManager => null;

		public static List<string> addedScenes => null;

		public static bool autoUnloadAdditiveScenes
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static AsyncOperation currentAsyncOperation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static SavedGameData currentSavedGameData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static GameObject playerSpawnpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static int currentSceneIndex => 0;

		public static event SceneLoadedDelegate sceneLoaded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action saveStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action saveEnded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action loadStarted
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action loadEnded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static event Action saveDataApplied
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public static string GetCurrentSceneName()
		{
			return null;
		}

		public static int GetCurrentSceneIndex()
		{
			return 0;
		}

		[IteratorStateMachine(typeof(_003CLoadSceneInternal_003Ed__90))]
		private static IEnumerator LoadSceneInternal(string sceneName, SceneValidationMode sceneValidationMode)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadSceneInternalTransitionCoroutine_003Ed__91))]
		private static IEnumerator LoadSceneInternalTransitionCoroutine(string sceneName, SceneValidationMode sceneValidationMode)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CLoadAdditiveSceneInternal_003Ed__92))]
		public static IEnumerator LoadAdditiveSceneInternal(string sceneName, SceneValidationMode sceneValidationMode)
		{
			return null;
		}

		public static void UnloadAdditiveSceneInternal(string sceneName)
		{
		}

		public static void RecursivelyRecordSavers(Transform t, int sceneIndex)
		{
		}

		public static void RecursivelyApplySavers(Transform t)
		{
		}

		public static void RecursivelyInformBeforeSceneChange(Transform t)
		{
		}

		public void SaveGameToSlot(int slotNumber)
		{
		}

		public void LoadGameFromSlot(int slotNumber)
		{
		}

		public void LoadSceneAtSpawnpoint(string sceneNameAndSpawnpoint)
		{
		}

		public static bool HasSavedGameInSlot(int slotNumber)
		{
			return false;
		}

		public static void DeleteSavedGameInSlot(int slotNumber)
		{
		}

		public static void SaveToSlot(int slotNumber)
		{
		}

		[IteratorStateMachine(typeof(_003CSaveToSlotCoroutine_003Ed__103))]
		private static IEnumerator SaveToSlotCoroutine(int slotNumber)
		{
			return null;
		}

		public static void SaveToSlotImmediate(int slotNumber)
		{
		}

		public static void LoadFromSlot(int slotNumber)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadFromSlotCoroutine_003Ed__106))]
		private static IEnumerator LoadFromSlotCoroutine(int slotNumber)
		{
			return null;
		}

		private static void NotifyLoadEndedWhenSceneLoaded(string sceneName, int sceneIndex)
		{
		}

		private static void LoadFromSlotNow(int slotNumber)
		{
		}

		public static void RegisterSaver(Saver saver)
		{
		}

		public static void UnregisterSaver(Saver saver)
		{
		}

		public static void ClearSavedGameData()
		{
		}

		public static SavedGameData RecordSavedGameData()
		{
			return null;
		}

		private static int GetSaverSceneIndex(Saver saver)
		{
			return 0;
		}

		public static void UpdateSaveData(Saver saver, string data)
		{
		}

		public static void ApplySavedGameData(SavedGameData savedGameData)
		{
		}

		[IteratorStateMachine(typeof(_003CDelayedSaveDataAppliedCoroutine_003Ed__116))]
		protected static IEnumerator DelayedSaveDataAppliedCoroutine(int frames)
		{
			return null;
		}

		public static void ApplySavedGameData()
		{
		}

		public static void BeforeSceneChange()
		{
		}

		public static void LoadGame(SavedGameData savedGameData)
		{
		}

		public static void LoadScene(string sceneNameAndSpawnpoint)
		{
		}

		[IteratorStateMachine(typeof(_003CLoadSceneCoroutine_003Ed__121))]
		private static IEnumerator LoadSceneCoroutine(SavedGameData savedGameData, string spawnpointName, SceneValidationMode sceneValidationMode)
		{
			return null;
		}

		private static void ApplyDataImmediate()
		{
		}

		private void FinishedLoadingScene(string sceneName, int sceneIndex)
		{
		}

		public static void LoadAdditiveScene(string sceneName)
		{
		}

		public static void UnloadAdditiveScene(string sceneName)
		{
		}

		public static void UnloadAllAdditiveScenes()
		{
		}

		public static void RestartGame(string startingSceneName)
		{
		}

		public static void ResetGameState()
		{
		}

		public static void SaversRestartGame()
		{
		}

		public static string Serialize(object data)
		{
			return null;
		}

		public static T Deserialize<T>(string s, T data = default(T))
		{
			return default(T);
		}
	}
}
