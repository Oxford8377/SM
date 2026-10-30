using System.Collections.Generic;
using MoreMountains.InventoryEngine;

namespace PixelCrushers.InventoryEngineSupport
{
	public static class InventoryEngineUtils
	{
		public static bool debug;

		private static Dictionary<string, Inventory> inventoryCache;

		private static Dictionary<string, InventoryItem> itemCache;

		public static Inventory FindInventory(string inventoryName)
		{
			return null;
		}

		public static InventoryItem FindItem(string itemID)
		{
			return null;
		}

		public static void InitItemCache()
		{
		}

		public static int FindItemIndex(Inventory inventory, string itemID)
		{
			return 0;
		}

		public static void mmAddItem(string inventoryName, string itemID, int quantity)
		{
		}

		public static void mmRemoveItem(string inventoryName, string itemID, int quantity)
		{
		}

		public static int mmGetQuantity(string inventoryName, string itemID)
		{
			return 0;
		}

		public static void mmUseItem(string inventoryName, string itemID)
		{
		}

		public static void mmDropItem(string inventoryName, string itemID)
		{
		}

		public static void mmEquipItem(string inventoryName, string itemID)
		{
		}

		public static void mmUnEquipItem(string inventoryName, string itemID)
		{
		}

		public static void mmEmptyInventory(string inventoryName)
		{
		}
	}
}
