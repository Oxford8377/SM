using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	public static class Tools
	{
		[CompilerGenerated]
		private sealed class _003CSendMessageToEveryoneAsync_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string message;

			public int gameObjectsPerFrame;

			private GameObject[] _003CgameObjects_003E5__2;

			private int _003Ccount_003E5__3;

			private int _003Ci_003E5__4;

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
			public _003CSendMessageToEveryoneAsync_003Ed__16(int _003C_003E1__state)
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

		private static CursorLockMode previousLockMode;

		private static string[] htmlTags;

		private const RegexOptions Options = RegexOptions.IgnoreCase | RegexOptions.ExplicitCapture | RegexOptions.CultureInvariant;

		private static readonly Regex StylesRegex;

		private static readonly Regex StyleRegex;

		private static readonly Regex BoldRegex;

		private static readonly Regex ItalicRegex;

		private static readonly Regex ColorRegex;

		private static readonly Regex TextRegex;

		private static readonly Regex PartsRegex;

		public static string loadedLevelName => null;

		public static void DeprecationWarning(MonoBehaviour mb, string extraInfo = null)
		{
		}

		public static bool IsPrefab(GameObject go)
		{
			return false;
		}

		public static byte HexToByte(string hex)
		{
			return 0;
		}

		public static bool IsNumber(object o)
		{
			return false;
		}

		public static int StringToInt(string s)
		{
			return 0;
		}

		public static float StringToFloat(string s)
		{
			return 0f;
		}

		public static bool StringToBool(string s)
		{
			return false;
		}

		public static bool IsStringNullOrEmptyOrWhitespace(string s)
		{
			return false;
		}

		public static string GetAllAfterSlashes(string s)
		{
			return null;
		}

		public static string GetObjectName(UnityEngine.Object o)
		{
			return null;
		}

		public static string GetGameObjectName(Component c)
		{
			return null;
		}

		public static string GetFullName(GameObject go)
		{
			return null;
		}

		public static Transform Select(params Transform[] args)
		{
			return null;
		}

		public static MonoBehaviour Select(params MonoBehaviour[] args)
		{
			return null;
		}

		public static void SendMessageToEveryone(string message)
		{
		}

		public static void SendMessageToEveryone(string message, string arg)
		{
		}

		[IteratorStateMachine(typeof(_003CSendMessageToEveryoneAsync_003Ed__16))]
		public static IEnumerator SendMessageToEveryoneAsync(string message, int gameObjectsPerFrame)
		{
			return null;
		}

		public static void SetGameObjectActive(Component component, bool value)
		{
		}

		public static void SetGameObjectActive(GameObject gameObject, bool value)
		{
		}

		public static bool ApproximatelyZero(float x)
		{
			return false;
		}

		public static Color WebColor(string colorCode)
		{
			return default(Color);
		}

		public static string ToWebColor(Color color)
		{
			return null;
		}

		public static string StripRichTextCodes(string s)
		{
			return null;
		}

		public static string StripTextMeshProTags(string s)
		{
			return null;
		}

		public static bool IsClipInAnimations(Animation animation, string clipName)
		{
			return false;
		}

		public static GameObject GameObjectHardFind(string goName)
		{
			return null;
		}

		public static GameObject GameObjectHardFind(string goName, string tag)
		{
			return null;
		}

		public static GameObject[] FindGameObjectsWithTagHard(string tag)
		{
			return null;
		}

		private static void GameObjectSearchForTags(Transform t, string tag, List<GameObject> list)
		{
		}

		public static T GetComponentAnywhere<T>(GameObject gameObject) where T : Component
		{
			return null;
		}

		public static float GetGameObjectHeight(GameObject gameObject)
		{
			return 0f;
		}

		public static void SetComponentEnabled(Component component, Toggle state)
		{
		}

		public static bool IsCursorActive()
		{
			return false;
		}

		public static void SetCursorActive(bool value)
		{
		}

		public static bool IsCursorVisible()
		{
			return false;
		}

		public static bool IsCursorLocked()
		{
			return false;
		}

		public static void ShowCursor(bool value)
		{
		}

		public static void LockCursor(bool value)
		{
		}

		public static void LoadLevel(int index)
		{
		}

		public static void LoadLevel(string name)
		{
		}

		public static AsyncOperation LoadLevelAsync(string name)
		{
			return null;
		}

		public static AsyncOperation LoadLevelAsync(int index)
		{
			return null;
		}

		public static string RemoveHtml(string s)
		{
			return null;
		}

		public static string ReplaceHtmlCharacterCodes(string s)
		{
			return null;
		}

		private static string ReplaceMarkup(string s)
		{
			return null;
		}

		private static string ConvertToRichText(string s)
		{
			return null;
		}

		private static string ApplyStyle(string innerText, bool bold, bool italic, string color)
		{
			return null;
		}

		private static void WrapInTag(ref StringBuilder builder, string tag, string value = "")
		{
		}
	}
}
