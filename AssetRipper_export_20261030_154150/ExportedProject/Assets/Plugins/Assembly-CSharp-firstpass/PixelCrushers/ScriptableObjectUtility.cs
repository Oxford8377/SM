using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public static class ScriptableObjectUtility
	{
		public static T CreateScriptableObject<T>() where T : ScriptableObject
		{
			return null;
		}

		public static ScriptableObject CreateScriptableObject(Type type)
		{
			return null;
		}

		public static void InitializeScriptableObject(ScriptableObject scriptableObject)
		{
		}

		public static List<T> CloneList<T>(List<T> original, UnityEngine.Object source = null) where T : ScriptableObject
		{
			return null;
		}
	}
}
