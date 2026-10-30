using System;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class ActiveSaver : Saver
	{
		[Serializable]
		public class Data
		{
			public bool active;
		}

		[SerializeField]
		[Tooltip("GameObject to watch.")]
		private GameObject m_gameObjectToWatch;

		private Data m_data;

		public GameObject gameObjectToWatch
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
