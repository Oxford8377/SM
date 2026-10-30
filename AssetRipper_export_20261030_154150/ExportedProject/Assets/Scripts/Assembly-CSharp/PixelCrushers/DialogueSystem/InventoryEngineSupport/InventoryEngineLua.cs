using System.Collections.Generic;
using MoreMountains.InventoryEngine;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.InventoryEngineSupport
{
	[AddComponentMenu("Pixel Crushers/Dialogue System/Third Party/Inventory Engine/Inventory Engine Lua (on Dialogue Manager)")]
	public class InventoryEngineLua : MonoBehaviour
	{
		[Tooltip("Cache item info on start to avoid delay when using first Lua function.")]
		public bool initItemCacheOnStart;

		public bool debug;

		private Dictionary<string, Inventory> inventoryCache;

		private bool didIRegister;

		private static bool s_registered;

		private static Dictionary<string, InventoryItem> itemCache;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public Inventory FindInventory(string inventoryName)
		{
			return null;
		}

		public InventoryItem FindItem(string itemID, bool logWarningIfNotFound = true)
		{
			return null;
		}

		public static void InitItemCache()
		{
		}

		public int FindItemIndex(Inventory inventory, string itemID)
		{
			return 0;
		}

		public void mmAddItem(string inventoryName, string itemID, double quantity)
		{
		}

		public void mmRemoveItem(string inventoryName, string itemID, double quantity)
		{
		}

		public double mmGetQuantity(string inventoryName, string itemID)
		{
			return 0.0;
		}

		public void mmUseItem(string inventoryName, string itemID)
		{
		}

		public void mmDropItem(string inventoryName, string itemID)
		{
		}

		public void mmEquipItem(string inventoryName, string itemID)
		{
		}

		public void mmUnEquipItem(string inventoryName, string itemID)
		{
		}

		public void mmEmptyInventory(string inventoryName)
		{
		}

		public double mmGetNumFreeSlots(string inventoryName)
		{
			return 0.0;
		}

		public double mmGetNumFilledSlots(string inventoryName)
		{
			return 0.0;
		}

		public void mmResizeSlots(string inventoryName, double columns, double rows)
		{
		}
	}
}
