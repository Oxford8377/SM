using System;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class MultiActiveSaver : Saver
	{
		[Serializable]
		public class Data
		{
			public bool[] active;
		}

		[Tooltip("GameObjects to watch.")]
		[SerializeField]
		private GameObject[] m_gameObjectsToWatch;

		private Data m_data;

		public GameObject[] gameObjectsToWatch
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string RecordData()
		{
			return null;
		}

		public override void ApplyData(string s)
		{
		}
	}
}
