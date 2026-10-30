using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ActorSubtitleColor : MonoBehaviour
	{
		public enum ApplyTo
		{
			DialogueText = 0,
			PrependedActorName = 1
		}

		[Tooltip("Color to use for subtitle lines spoken by this actor.")]
		public Color color;

		[Tooltip("Apply color to entire Dialogue Text or prepend actor name and apply color only to name.")]
		public ApplyTo applyTo;

		[Tooltip("If prepending actor name, separate from Dialogue Text with this string.")]
		public string prependActorNameSeparator;

		public void OnConversationLine(Subtitle subtitle)
		{
		}

		public void OnBarkLine(Subtitle subtitle)
		{
		}

		private void CheckSubtitle(Subtitle subtitle)
		{
		}

		private string ProcessText(Subtitle subtitle)
		{
			return null;
		}
	}
}
