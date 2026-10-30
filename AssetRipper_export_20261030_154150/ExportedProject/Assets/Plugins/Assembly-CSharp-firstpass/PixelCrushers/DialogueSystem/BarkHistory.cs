using System.Collections.Generic;

namespace PixelCrushers.DialogueSystem
{
	public class BarkHistory
	{
		public BarkOrder order;

		public int index;

		public List<int> entries;

		public BarkHistory(BarkOrder order)
		{
		}

		public int GetNextIndex(int numEntries)
		{
			return 0;
		}

		public void Reset()
		{
		}
	}
}
