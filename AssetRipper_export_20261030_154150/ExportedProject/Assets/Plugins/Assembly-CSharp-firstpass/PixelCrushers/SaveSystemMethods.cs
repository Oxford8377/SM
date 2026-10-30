using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class SaveSystemMethods : MonoBehaviour
	{
		[Tooltip("Scene to load in LoadOrRestart method if no saved game exists yet.")]
		public string defaultStartingSceneName;

		public virtual void SaveSlot(int slotNumber)
		{
		}

		public virtual void LoadFromSlot(int slotNumber)
		{
		}

		public virtual void LoadScene(string sceneNameAndSpawnpoint)
		{
		}

		public virtual void ResetGameState()
		{
		}

		public virtual void RestartGame(string startingSceneName)
		{
		}

		public virtual void LoadOrRestart(int slotNumber)
		{
		}

		public virtual void DeleteSavedGameInSlot(int slotNumber)
		{
		}

		public virtual void RecordSavedGameData()
		{
		}

		public virtual void ApplySavedGameData()
		{
		}

		public virtual void LoadAdditiveScene(string sceneName)
		{
		}

		public virtual void UnloadAdditiveScene(string sceneName)
		{
		}
	}
}
