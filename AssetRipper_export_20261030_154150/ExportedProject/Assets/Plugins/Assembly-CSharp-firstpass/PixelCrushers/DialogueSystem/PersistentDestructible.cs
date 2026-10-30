using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class PersistentDestructible : MonoBehaviour
	{
		public enum RecordOn
		{
			Destroy = 0,
			Disable = 1
		}

		[Tooltip("Record destroyed on Destroy or Disable.")]
		public RecordOn recordOn;

		[Tooltip("Unique Dialogue System variable (Boolean) to record whether the GameObject has been destroyed/disabled.")]
		public string variableName;

		[Tooltip("Spawn an instance of this when destroyed.")]
		public GameObject spawnWhenDestroyed;

		protected bool listenForOnDestroy;

		protected string ActualVariableName => null;

		protected virtual void OnEnable()
		{
		}

		public void OnApplyPersistentData()
		{
		}

		public void OnLevelWillBeUnloaded()
		{
		}

		public void OnApplicationQuit()
		{
		}

		public void OnDestroy()
		{
		}

		private void MarkDestroyed()
		{
		}

		public void OnDisable()
		{
		}

		private void SpawnCorpse()
		{
		}
	}
}
