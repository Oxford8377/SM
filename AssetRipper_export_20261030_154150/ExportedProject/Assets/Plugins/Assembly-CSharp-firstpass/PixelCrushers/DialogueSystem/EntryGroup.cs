using System;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class EntryGroup
	{
		public string name;

		public Rect rect;

		public Color color;

		public EntryGroup()
		{
		}

		public EntryGroup(string name, Rect rect)
		{
		}

		public EntryGroup(EntryGroup source)
		{
		}
	}
}
