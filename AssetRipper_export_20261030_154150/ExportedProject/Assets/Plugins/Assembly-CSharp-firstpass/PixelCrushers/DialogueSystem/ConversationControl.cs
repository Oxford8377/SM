using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class ConversationControl : MonoBehaviour
	{
		[Tooltip("Skip all subtitles until response menu or end of conversation is reached. Set by SkipAll().")]
		public bool skipAll;

		[Tooltip("Stop SkipAll() when response menu is reached.")]
		public bool stopSkipAllOnResponseMenu;

		[Tooltip("Stop SkipAll() when end of conversation is reached.")]
		public bool stopSkipAllOnConversationEnd;

		protected AbstractDialogueUI dialogueUI;

		protected virtual void Awake()
		{
		}

		public virtual void ToggleAutoPlay()
		{
		}

		public virtual void SkipAll()
		{
		}

		public virtual void StopSkipAll()
		{
		}

		public virtual void OnConversationLine(Subtitle subtitle)
		{
		}

		public virtual void OnConversationResponseMenu(Response[] responses)
		{
		}

		public virtual void OnConversationEnd(Transform actor)
		{
		}
	}
}
