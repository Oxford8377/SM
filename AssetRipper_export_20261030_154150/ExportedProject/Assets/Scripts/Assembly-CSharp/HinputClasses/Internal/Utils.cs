using System.Collections;
using UnityEngine;

namespace HinputClasses.Internal
{
	public static class Utils
	{
		public enum OS
		{
			Unknown = 0,
			Windows = 1,
			Mac = 2,
			Linux = 3
		}

		public const float maxGamepads = 8f;

		public const float stickPositionMultiplier = 1.01f;

		public const string inputManagerPath = "./ProjectSettings/InputManager.asset";

		private static OS _os;

		public static OS os => default(OS);

		public static bool HinputIsInstalled()
		{
			return false;
		}

		public static string HinputInputArray()
		{
			return null;
		}

		public static bool GetButton(string fullName)
		{
			return false;
		}

		public static float GetAxis(string fullName)
		{
			return 0f;
		}

		public static float GetAxis(string fullName, bool logError)
		{
			return 0f;
		}

		public static bool PushedTowards(this Stick stick, float angle)
		{
			return false;
		}

		public static void Coroutine(IEnumerator coroutine)
		{
		}

		public static void StopRoutines()
		{
		}

		public static bool IsEqualTo(this float target, float other)
		{
			return false;
		}

		public static bool IsNotEqualTo(this float target, float other)
		{
			return false;
		}

		public static Vector2 Clamp(this Vector2 target, float min, float max)
		{
			return default(Vector2);
		}

		private static void HinputNotSetUpError()
		{
		}

		public static void MissingInputArrayError()
		{
		}

		public static void SetupError()
		{
		}

		public static void UninstallError()
		{
		}

		public static void VibrationNotAvailableError()
		{
		}
	}
}
