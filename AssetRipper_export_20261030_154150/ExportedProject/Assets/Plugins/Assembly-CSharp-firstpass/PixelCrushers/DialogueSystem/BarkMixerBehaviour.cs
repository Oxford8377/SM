using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	public class BarkMixerBehaviour : PlayableBehaviour
	{
		private HashSet<int> played;

		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		protected Subtitle GetBarkSubtitle(string conversationTitle, int entryID, Transform speaker, Transform listener)
		{
			return null;
		}

		public override void OnGraphStart(Playable playable)
		{
		}

		public override void OnGraphStop(Playable playable)
		{
		}
	}
}
