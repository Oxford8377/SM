using System;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	public class MultiEnabledSaver : Saver
	{
		[Serializable]
		public class Data
		{
			public bool[] active;
		}

		[SerializeField]
		[Tooltip("Components to watch.")]
		private Component[] m_componentsToWatch;

		private Data m_data;

		public Component[] componentsToWatch
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
