using MoreMountains.InventoryEngine;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.InventoryEngineSupport
{
	[RequireComponent(typeof(Inventory))]
	[AddComponentMenu("Pixel Crushers/Dialogue System/Third Party/Inventory Engine/Persistent Inventory")]
	public class PersistentInventory : MonoBehaviour
	{
		public string playerID;

		[Tooltip("Dialogue System Lua variable under which to save inventory.")]
		public string savedDataVariableName;

		protected string actualVariableName => null;

		public void OnRecordPersistentData()
		{
		}

		public void OnApplyPersistentData()
		{
		}

		public void OnEnable()
		{
		}

		public void OnDisable()
		{
		}
	}
}
