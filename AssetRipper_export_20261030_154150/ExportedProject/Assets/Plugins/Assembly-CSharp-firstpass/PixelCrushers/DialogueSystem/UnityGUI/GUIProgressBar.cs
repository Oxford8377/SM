using UnityEngine;

namespace PixelCrushers.DialogueSystem.UnityGUI
{
	[AddComponentMenu(null)]
	public class GUIProgressBar : GUIVisibleControl
	{
		public enum Origin
		{
			Top = 0,
			Bottom = 1,
			Left = 2,
			Right = 3,
			HorizontalCenter = 4,
			VerticalCenter = 5
		}

		public Origin origin;

		public Texture2D emptyImage;

		public Texture2D fullImage;

		public float progress;

		public override void DrawSelf(Vector2 relativeMousePosition)
		{
		}
	}
}
