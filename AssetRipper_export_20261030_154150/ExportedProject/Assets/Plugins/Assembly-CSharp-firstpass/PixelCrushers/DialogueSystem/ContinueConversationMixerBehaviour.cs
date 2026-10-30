using System.Collections.Generic;
using UnityEngine.Playables;

namespace PixelCrushers.DialogueSystem
{
	public class ContinueConversationMixerBehaviour : PlayableBehaviour
	{
		private HashSet<int> played;

		public override void ProcessFrame(Playable playable, FrameData info, object playerData)
		{
		}

		private string GetEditorContinueText(Playable playable)
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
