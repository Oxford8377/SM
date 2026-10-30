using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class DiskSavedGameDataStorer : SavedGameDataStorer
	{
		public enum BasePath
		{
			PersistentDataPath = 0,
			DataPath = 1,
			Custom = 2
		}

		protected class SavedGameInfo
		{
			public string sceneName;

			public SavedGameInfo(string sceneName)
			{
			}
		}

		[Tooltip("Persistent Data Path: Usual location where Unity stores data to be kept between runs.\nData Path: Game data folder on target device.\nCustom: Set below.")]
		public BasePath storeSaveFilesIn;

		public string customPath;

		[Tooltip("Encrypt saved game files.")]
		public bool encrypt;

		[Tooltip("If encrypting, use this password.")]
		public string encryptionPassword;

		[SerializeField]
		[Tooltip("Log debug info.")]
		private bool m_debug;

		protected List<SavedGameInfo> m_savedGameInfo;

		protected List<SavedGameInfo> savedGameInfo => null;

		public bool debug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual void Start()
		{
		}

		protected virtual string GetBasePath()
		{
			return null;
		}

		public virtual string GetSaveGameFilename(int slotNumber)
		{
			return null;
		}

		public virtual string GetSavedGameInfoFilename()
		{
			return null;
		}

		public virtual void LoadSavedGameInfoFromFile()
		{
		}

		protected virtual bool VerifySavedGameInfoFile(string saveInfoFilename)
		{
			return false;
		}

		public virtual void UpdateSavedGameInfoToFile(int slotNumber, SavedGameData savedGameData)
		{
		}

		protected virtual void WriteSavedGameInfoToDisk()
		{
		}

		public override bool HasDataInSlot(int slotNumber)
		{
			return false;
		}

		public override void StoreSavedGameData(int slotNumber, SavedGameData savedGameData)
		{
		}

		public override SavedGameData RetrieveSavedGameData(int slotNumber)
		{
			return null;
		}

		public override void DeleteSavedGameData(int slotNumber)
		{
		}

		public static void WriteStringToFile(string filename, string data)
		{
		}

		public static string ReadStringFromFile(string filename)
		{
			return null;
		}
	}
}
