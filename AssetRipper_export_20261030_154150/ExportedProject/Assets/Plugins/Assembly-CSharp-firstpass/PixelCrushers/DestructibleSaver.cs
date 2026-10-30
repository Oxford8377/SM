using System;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class DestructibleSaver : Saver
	{
		[Serializable]
		public class DestructibleData
		{
			public bool destroyed;

			public Vector3 position;
		}

		public enum Mode
		{
			OnDisable = 0,
			OnDestroy = 1
		}

		public enum DestroyMode
		{
			Destroy = 0,
			Deactivate = 1
		}

		[Tooltip("Event to watch for.")]
		[SerializeField]
		private Mode m_mode;

		[SerializeField]
		[Tooltip("How to re-destroy object.")]
		private DestroyMode m_destroyMode;

		[Tooltip("Instantiate this if already destroyed when loading game or scene.")]
		[SerializeField]
		private GameObject m_destroyedVersionPrefab;

		private DestructibleData m_data;

		private bool m_ignoreOnDestroy;

		public Mode mode
		{
			get
			{
				return default(Mode);
			}
			set
			{
			}
		}

		public DestroyMode destroyMode
		{
			get
			{
				return default(DestroyMode);
			}
			set
			{
			}
		}

		public GameObject destroyedVersionPrefab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void OnBeforeSceneChange()
		{
		}

		public override void OnDisable()
		{
		}

		public override void OnDestroy()
		{
		}

		public virtual void RecordDestruction()
		{
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string s)
		{
		}
	}
}
