using UnityEngine;

namespace PixelCrushers
{
	public abstract class Saver : MonoBehaviour
	{
		[Tooltip("Save data under this key. If blank, use GameObject name.")]
		[SerializeField]
		private string m_key;

		[SerializeField]
		[Tooltip("Append the name of this saver type to the key.")]
		private bool m_appendSaverTypeToKey;

		[SerializeField]
		[Tooltip("Save when changing scenes to be able to restore saved state when returning to scene.")]
		private bool m_saveAcrossSceneChanges;

		[SerializeField]
		[Tooltip("When starting, restore this saver's state from current saved game data. Normally the save system restores state when loading games or changing scenes without this checkbox.")]
		private bool m_restoreStateOnStart;

		protected string m_runtimeKey;

		public bool appendSaverTypeToKey
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual string key
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string _internalKeyValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual bool saveAcrossSceneChanges
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual bool restoreStateOnStart
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		public virtual void Start()
		{
		}

		public virtual void Reset()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void OnDestroy()
		{
		}

		public abstract string RecordData();

		public abstract void ApplyData(string s);

		public virtual void ApplyDataImmediate()
		{
		}

		public virtual void OnBeforeSceneChange()
		{
		}

		public virtual void OnRestartGame()
		{
		}
	}
}
