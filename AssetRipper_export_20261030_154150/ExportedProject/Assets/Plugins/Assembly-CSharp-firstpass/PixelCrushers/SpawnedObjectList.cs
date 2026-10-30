using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	public class SpawnedObjectList : ScriptableObject
	{
		[SerializeField]
		[Tooltip("Save unique data on this spawned object's Saver components.")]
		private List<SpawnedObject> m_spawnedObjectPrefabs;

		public List<SpawnedObject> spawnedObjectPrefabs
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
