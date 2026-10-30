using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class SetLocalizedFont : MonoBehaviour
	{
		[SerializeField]
		private bool m_setOnEnable;

		[SerializeField]
		[Tooltip("Overrides UILocalizationManager's Localized Fonts if set.")]
		private LocalizedFonts m_localizedFonts;

		private bool m_started;

		private float m_initialFontSize;

		private Text text;

		private TextMeshProUGUI textMeshPro;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public void SetCurrentLocalizedFont()
		{
		}
	}
}
