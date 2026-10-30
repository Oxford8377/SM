using MoreMountains.InventoryEngine;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem.InventoryEngineSupport
{
	[RequireComponent(typeof(Inventory))]
	[AddComponentMenu("Pixel Crushers/Dialogue System/Third Party/Inventory Engine/Dialogue System Inventory Event Listener")]
	public class DialogueSystemInventoryEventListener : MonoBehaviour, MMEventListener<MMInventoryEvent>, MMEventListenerBase, MMEventListener<MMGameEvent>
	{
		[Tooltip("Update the quest tracker when the inventory's content changes.")]
		public bool updateQuestTracker;

		[Tooltip("Save & load Dialogue System data when More Mountains SaveLoadManager requests. If using DialogueSystemCorgiEventListener, UNtick this on one or the other.")]
		public bool handleMMSaveLoadEvents;

		public UnityEvent onContentChanged;

		protected const string _saveFolderName = "DialogueSystem/";

		protected const string _saveFileExtension = ".data";

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public virtual void OnMMEvent(MMInventoryEvent eventType)
		{
		}

		public virtual void OnMMEvent(MMGameEvent gameEvent)
		{
		}

		public void SaveDialogueSystem()
		{
		}

		public void LoadDialogueSystem()
		{
		}
	}
}
