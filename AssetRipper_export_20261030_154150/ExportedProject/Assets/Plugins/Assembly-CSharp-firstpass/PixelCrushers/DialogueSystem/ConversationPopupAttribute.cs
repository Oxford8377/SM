using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public class ConversationPopupAttribute : PropertyAttribute
	{
		public bool showReferenceDatabase;

		public bool showFilter;

		public ConversationPopupAttribute(bool showReferenceDatabase = false, bool showFilter = false)
		{
		}
	}
}
