using System.Collections.Generic;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	public class QuestStateMixerBehaviour : PlayableBehaviour
	{
		private HashSet<int> played;

		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		public override void OnGraphStart(Playable playable)
		{
		}

		public override void OnGraphStop(Playable playable)
		{
		}
	}
}
