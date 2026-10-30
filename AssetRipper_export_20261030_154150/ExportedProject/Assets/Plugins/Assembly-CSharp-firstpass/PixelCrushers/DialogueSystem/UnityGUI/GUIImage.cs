using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[AddComponentMenu(null)]
	public class GUIImage : GUIVisibleControl
	{
		public GUIImageParams image;

		public ImageAnimation imageAnimation;

		public override void DrawSelf(Vector2 relativeMousePosition)
		{
		}

		public override void Refresh()
		{
		}
	}
}
