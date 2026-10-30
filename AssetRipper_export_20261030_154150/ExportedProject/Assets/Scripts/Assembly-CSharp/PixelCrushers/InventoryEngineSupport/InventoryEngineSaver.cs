using MoreMountains.InventoryEngine;
using UnityEngine;

namespace PixelCrushers.InventoryEngineSupport
{
	[AddComponentMenu("Pixel Crushers/Save System/Savers/Inventory Engine/Inventory Engine Saver")]
	[RequireComponent(typeof(Inventory))]
	public class InventoryEngineSaver : Saver
	{
		public string playerID;

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string s)
		{
		}
	}
}
