using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public static class GameObjectUtility
	{
		public static T FindFirstObjectByType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		public static UnityEngine.Object FindFirstObjectByType(Type type)
		{
			return null;
		}

		public static T[] FindObjectsByType<T>() where T : UnityEngine.Object
		{
			return null;
		}

		public static UnityEngine.Object[] FindObjectsByType(Type type)
		{
			return null;
		}

		public static bool IsPrefab(GameObject go)
		{
			return false;
		}

		public static bool DoesGameObjectPathMatch(Transform t, string requiredPath)
		{
			return false;
		}

		public static string GetHierarchyPath(Transform t)
		{
			return null;
		}

		public static GameObject GameObjectHardFind(string goName, bool checkAllScenes = true)
		{
			return null;
		}

		public static GameObject GameObjectHardFind(string goName, string tag, bool checkAllScenes = true)
		{
			return null;
		}

		private static GameObject GameObjectHardFindRootObjects(string goName, string tag, GameObject[] rootGameObjects)
		{
			return null;
		}

		private static GameObject GameObjectSearchHierarchy(Transform t, string goName, string tag)
		{
			return null;
		}

		public static T[] FindObjectsOfTypeAlsoInactive<T>(bool checkAllScenes = true) where T : Component
		{
			return null;
		}

		private static void FindObjectsSearchRootObjects<T>(GameObject[] rootGameObjects, List<T> list) where T : Component
		{
		}

		private static void FindObjectsSearchHierarchy<T>(Transform t, List<T> list) where T : Component
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
	}
}
