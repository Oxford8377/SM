using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers
{
	[Serializable]
	public class UIDropdownField
	{
		[SerializeField]
		private Dropdown m_uiDropdown;

		[SerializeField]
		private TMP_Dropdown m_tmpDropdown;

		public Dropdown uiDropdown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TMP_Dropdown tmpDropdown
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int value
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool enabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public GameObject gameObject => null;

		public bool isActiveSelf => false;

		public bool activeInHierarchy => false;

		public UIDropdownField()
		{
		}

		public UIDropdownField(Dropdown uiDropdown)
		{
		}

		public UIDropdownField(TMP_Dropdown tmpDropdown)
		{
		}

		public void SetActive(bool value)
		{
		}

		public void ClearOptions()
		{
		}

		public void AddOption(string text)
		{
		}

		public static bool IsNull(UIDropdownField uiDropdownField)
		{
			return false;
		}
	}
}
