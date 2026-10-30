using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	public class SavedGameData : ISerializationCallbackReceiver
	{
		[Serializable]
		public class SaveRecord
		{
			public string key;

			public int sceneIndex;

			public string data;

			public SaveRecord()
			{
			}

			public SaveRecord(string key, int sceneIndex, string data)
			{
			}
		}

		[SerializeField]
		private int m_version;

		[SerializeField]
		private string m_sceneName;

		private Dictionary<string, SaveRecord> m_dict;

		[SerializeField]
		private List<SaveRecord> m_list;

		public int version
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string sceneName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dictionary<string, SaveRecord> Dict => null;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public SaveRecord GetDataInfo(string key)
		{
			return null;
		}

		public string GetData(string key)
		{
			return null;
		}

		public void SetData(string key, int sceneIndex, string data)
		{
		}

		public void DeleteData(string key)
		{
		}

		public void DeleteObsoleteSaveData(int currentSceneIndex)
		{
		}
	}
}
