using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class OverrideDisplaySettings : OverrideUIBase
	{
		[Tooltip("Use these display settings when this GameObject is involved in conversation.")]
		public DisplaySettings displaySettings;
	}
}
