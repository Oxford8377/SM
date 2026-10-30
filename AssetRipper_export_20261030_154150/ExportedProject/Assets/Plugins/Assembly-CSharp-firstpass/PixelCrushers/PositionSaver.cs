using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class PositionSaver : Saver
	{
		[Serializable]
		public class PositionData
		{
			public int scene;

			public Vector3 position;

			public Quaternion rotation;
		}

		[Serializable]
		public class ScenePositionData
		{
			public int scene;

			public Vector3 position;

			public Quaternion rotation;

			public ScenePositionData(int _scene, Vector3 _position, Quaternion _rotation)
			{
			}
		}

		[Serializable]
		public class MultiscenePositionData
		{
			public List<ScenePositionData> positions;
		}

		[Tooltip("If set, save position of target. Otherwise save this GameObject's position.")]
		[SerializeField]
		private Transform m_target;

		[Tooltip("When changing scenes, if a player spawnpoint is specified, move this GameObject to the spawnpoint.")]
		[SerializeField]
		private bool m_usePlayerSpawnpoint;

		[Tooltip("Record positions in every scene. If unticked, only records position in most recent scene.")]
		[SerializeField]
		private bool m_multiscene;

		protected PositionData m_data;

		protected MultiscenePositionData m_multisceneData;

		protected NavMeshAgent m_navMeshAgent;

		public Transform target
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool usePlayerSpawnpoint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected bool multiscene => false;

		public override void Awake()
		{
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string s)
		{
		}

		protected virtual void SetPosition(Vector3 position, Quaternion rotation)
		{
		}
	}
}
