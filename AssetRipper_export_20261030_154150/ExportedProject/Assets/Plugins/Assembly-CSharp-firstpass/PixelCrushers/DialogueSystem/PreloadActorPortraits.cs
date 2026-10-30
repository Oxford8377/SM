using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class PreloadActorPortraits : MonoBehaviour
	{
		[Tooltip("Preload for Unity UI.")]
		public bool supportUnityUI;

		[Tooltip("If preloading for Unity UI, collapse legacy textures to save memory. Dialogue Manager's Instantiate Database must be ticked.")]
		public bool collapseLegacyTextures;

		private List<Texture2D> legacyPortraits;

		private void Start()
		{
		}

		public void PreloadActor(Actor actor)
		{
		}

		public Texture2D PreloadTexture(Texture2D texture)
		{
			return null;
		}
	}
}
