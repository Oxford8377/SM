using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class PlayerPrefsSavedGameDataStorer : SavedGameDataStorer
	{
		[Tooltip("Save games under this PlayerPrefs key")]
		[SerializeField]
		private string m_playerPrefsKeyBase;

		[Tooltip("Encrypt saved game data.")]
		public bool encrypt;

		[Tooltip("If encrypting, use this password.")]
		public string encryptionPassword;

		[SerializeField]
		[Tooltip("Log debug info.")]
		private bool m_debug;

		public string playerPrefsKeyBase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool debug => false;

		public string GetPlayerPrefsKey(int slotNumber)
		{
			return null;
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
	}
}
