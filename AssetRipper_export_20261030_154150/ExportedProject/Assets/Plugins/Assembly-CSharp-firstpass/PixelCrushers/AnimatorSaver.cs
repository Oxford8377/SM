using System;
using System.Collections.Generic;
using UnityEngine;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	[RequireComponent(typeof(Animator))]
	public class AnimatorSaver : Saver
	{
		[Serializable]
		public class LayerData
		{
			public int hash;

			public float time;
		}

		[Serializable]
		public class TriggerData
		{
			public string name;

			public bool isTriggered;
		}

		[Serializable]
		public class Data
		{
			public LayerData[] layers;

			public List<bool> bools;

			public List<float> floats;

			public List<int> ints;

			public List<string> strings;

			public List<TriggerData> triggers;
		}

		private Data m_data;

		private Animator m_animator;

		private Animator animator => null;

		private void CheckAnimator()
		{
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
