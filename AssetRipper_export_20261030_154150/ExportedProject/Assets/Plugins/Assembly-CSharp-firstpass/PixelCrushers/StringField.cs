using System;
using UnityEngine;

namespace PixelCrushers
{
	[Serializable]
	public class StringField : IEquatable<StringField>
	{
		[Tooltip("The string that holds the value of this string field. Unused if String Asset or Text Table is assigned.")]
		[SerializeField]
		private string m_text;

		[Tooltip("The String Asset that holds the value of this string field. Unused if Text or Text Table is assigned.")]
		[SerializeField]
		private StringAsset m_stringAsset;

		[Tooltip("The Text Table that holds the value of this string field. Unused if Text or String Asset is assigned.")]
		[SerializeField]
		private TextTable m_textTable;

		[Tooltip("The field ID in the Text Table.")]
		[SerializeField]
		private int m_textTableFieldID;

		public static readonly StringField empty;

		public string text
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public StringAsset stringAsset
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

		public int textTableFieldID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}

		public StringField()
		{
		}

		public StringField(string text)
		{
		}

		public StringField(StringAsset stringAsset)
		{
		}

		public StringField(TextTable textTable, int fieldID)
		{
		}

		public StringField(StringField source)
		{
		}

		public void SetDefaultTextTable(TextTable textTable)
		{
		}

		public static bool operator ==(StringField obj1, StringField obj2)
		{
			return false;
		}

		public static bool operator !=(StringField obj1, StringField obj2)
		{
			return false;
		}

		public bool Equals(StringField other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool IsNullOrEmpty(StringField stringField)
		{
			return false;
		}

		public static string GetStringValue(StringField stringField)
		{
			return null;
		}
	}
}
