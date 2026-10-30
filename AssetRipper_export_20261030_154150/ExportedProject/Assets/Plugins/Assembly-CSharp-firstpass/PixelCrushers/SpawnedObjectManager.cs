using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class SpawnedObjectManager : Saver
	{
		[Serializable]
		public class SpawnedObjectData
		{
			public string prefabName;

			public Vector3 position;

			public Quaternion rotation;

			public string guid;

			public SpawnedObjectData()
			{
			}

			public SpawnedObjectData(string prefabName, Vector3 position, Quaternion rotation, string guid = null)
			{
			}
		}

		[Serializable]
		public class SpawnedObjectDataList
		{
			public List<SpawnedObjectData> list;
		}

		[CompilerGenerated]
		private sealed class _003CApplyDataToRespawnedObjectsAfterFrames_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public int numFrames;

			public SpawnedObjectManager _003C_003E4__this;

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
			public _003CApplyDataToRespawnedObjectsAfterFrames_003Ed__27(int _003C_003E1__state)
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

		[SerializeField]
		[Tooltip("Prefabs for all spawnable objects except those in Spawned Object Prefab Lists below. If your spawnable object isn't in this list or Spawned Object Prefab Lists, Spawned Object Manager won't be able to respawn it when restoring a scene.")]
		private List<SpawnedObject> m_spawnedObjectPrefabs;

		[Tooltip("Additional lists of spawnable object prefabs. If your spawnable object isn't in any of these lists or Spawned Object Prefabs above, Spawned Object Manager won't be able to respawn it when restoring a scene.")]
		[SerializeField]
		private List<SpawnedObjectList> m_spawnedObjectPrefabLists;

		[SerializeField]
		[Tooltip("Objects that have currently been spawned.")]
		private List<SpawnedObject> m_spawnedObjects;

		[Tooltip("When restoring this Spawned Object Manager, tell respawned objects to restore their saved data also.")]
		[SerializeField]
		private bool m_applySaveDataToSpawnedObjectsOnRestore;

		private static SpawnedObjectManager m_instance;

		public List<SpawnedObject> spawnedObjectPrefabs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<SpawnedObjectList> spawnedObjectPrefabLists
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<SpawnedObject> spawnedObjects
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool applySaveDataToSpawnedObjectsOnRestore
		{
			get
			{
				return false;
			}
			set
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

		public override void Reset()
		{
		}

		public override void Awake()
		{
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string data)
		{
		}

		protected virtual void ApplyDataToRespawnedObjects()
		{
		}

		[IteratorStateMachine(typeof(_003CApplyDataToRespawnedObjectsAfterFrames_003Ed__27))]
		protected IEnumerator ApplyDataToRespawnedObjectsAfterFrames(int numFrames)
		{
			return null;
		}

		protected virtual SpawnedObject GetSpawnedObjectPrefab(string prefabName)
		{
			return null;
		}

		public static void AddSpawnedObjectData(SpawnedObject spawnedObject)
		{
		}

		public static void RemoveSpawnedObjectData(SpawnedObject spawnedObject)
		{
		}
	}
}
