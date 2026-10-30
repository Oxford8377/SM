using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class UILocalizationManager : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UILocalizationManager _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CStart_003Ed__37(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		[Tooltip("The PlayerPrefs key to store the player's selected language code.")]
		private string m_currentLanguagePlayerPrefsKey;

		[SerializeField]
		[Tooltip("Overrides the global text table.")]
		private TextTable m_textTable;

		[SerializeField]
		[Tooltip("Any additional text tables.")]
		private List<TextTable> m_additionalTextTables;

		[Tooltip("Table of fonts to use for specific languages.")]
		[SerializeField]
		private LocalizedFonts m_localizedFonts;

		[Tooltip("When starting, set current language to value saved in PlayerPrefs.")]
		[SerializeField]
		private bool m_saveLanguageInPlayerPrefs;

		[Tooltip("When updating UIs, perform longer search that also finds LocalizeUI components on inactive GameObjects.")]
		[SerializeField]
		private bool m_alsoUpdateInactiveLocalizeUI;

		[SerializeField]
		[Tooltip("If a language's field value is blank, use default language's field value.")]
		private bool m_useDefaultLanguageForBlankTranslations;

		private string m_currentLanguage;

		private static UILocalizationManager s_instance;

		private static bool s_isQuitting;

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

		public static UILocalizationManager instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public List<TextTable> additionalTextTables
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentLanguage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string currentLanguagePlayerPrefsKey
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool saveLanguageInPlayerPrefs
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useDefaultLanguageForBlankTranslations
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void OnApplicationQuit()
		{
		}

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__37))]
		private IEnumerator Start()
		{
			return null;
		}

		public bool HasLanguage(string language)
		{
			return false;
		}

		public bool HasField(string fieldName)
		{
			return false;
		}

		public string GetFieldTextForLanguage(string fieldName, string language)
		{
			return null;
		}

		public string GetLocalizedText(string fieldName)
		{
			return null;
		}

		public void UpdateUIs(string language)
		{
		}
	}
}
