using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class LocalizeUI : MonoBehaviour
	{
		[Tooltip("Overrides the global text table.")]
		[SerializeField]
		private TextTable m_textTable;

		[Tooltip("Overrides the UILocalizationManager's Localized Fonts.")]
		[SerializeField]
		private LocalizedFonts m_localizedFonts;

		[Tooltip("(Optional) If assigned, use this instead of the UI element's text's value as the field lookup value.")]
		[SerializeField]
		private string m_fieldName;

		private bool m_started;

		private List<string> m_fieldNames;

		private List<string> m_tmpFieldNames;

		private Text m_text;

		private Dropdown m_dropdown;

		private TextMeshPro m_textMeshPro;

		private TextMeshProUGUI m_textMeshProUGUI;

		private TMP_Dropdown m_textMeshProDropdown;

		private bool m_lookedForTMP;

		public TextTable textTable
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedFonts localizedFonts
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string fieldName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected bool started
		{
			get
			{
				return false;
			}
			private set
			{
			}
		}

		protected List<string> fieldNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected List<string> tmpFieldNames
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Text text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Dropdown dropdown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextMeshPro textMeshPro
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TextMeshProUGUI textMeshProUGUI
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_Dropdown textMeshProDropdown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		public virtual void UpdateText()
		{
		}

		protected virtual bool HasLanguage(string language)
		{
			return false;
		}

		protected virtual bool HasField(string fieldName)
		{
			return false;
		}

		protected virtual string GetLocalizedText(string fieldName)
		{
			return null;
		}

		public virtual void SetFieldName(string newFieldName = "")
		{
		}

		public virtual void UpdateDropdownOptions()
		{
		}
	}
}
