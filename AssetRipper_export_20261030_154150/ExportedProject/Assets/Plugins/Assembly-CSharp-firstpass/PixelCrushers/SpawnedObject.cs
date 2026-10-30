using UnityEngine;
using UnityEngine.Serialization;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class SpawnedObject : Saver
	{
		public enum Mode
		{
			OnDisable = 0,
			OnDestroy = 1
		}

		[SerializeField]
		[FormerlySerializedAs("m_mode")]
		[Tooltip("Event to watch for to record that object was despawned.")]
		private Mode m_despawnMode;

		[Tooltip("Save unique data on this spawned object's Saver components.")]
		[SerializeField]
		private bool m_saveUniqueSaverData;

		private bool m_ignoreOnDestroy;

		private string m_guid;

		public Mode despawnMode
		{
			get
			{
				return default(Mode);
			}
			set
			{
			}
		}

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

		public bool saveUniqueSaverData
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string guid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public override void Start()
		{
		}

		protected virtual void AddGuidToSaverKeys()
		{
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

		protected virtual void RecordDestruction()
		{
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string data)
		{
		}
	}
}
