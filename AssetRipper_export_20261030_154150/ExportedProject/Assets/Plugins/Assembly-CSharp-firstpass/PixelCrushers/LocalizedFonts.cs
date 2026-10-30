using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace PixelCrushers
{
	public class LocalizedFonts : ScriptableObject
	{
		[Serializable]
		public class FontForLanguage
		{
			public string language;

			public Font font;

			public TMP_FontAsset textMeshProFont;

			[Tooltip("Scale this language's font size relative to initial font's size. (0.5 scales to half size, 2.0 scales to double size.)")]
			public float scaleRelativeToInitialFont;
		}

		public Font defaultFont;

		public TMP_FontAsset defaultTextMeshProFont;

		public List<FontForLanguage> fontsForLanguages;

		public Font GetFont(string language)
		{
			return null;
		}

		public TMP_FontAsset GetTextMeshProFont(string language)
		{
			return null;
		}

		public float GetFontScale(string language)
		{
			return 0f;
		}
	}
}
