using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class ContinueConversationClip : PlayableAsset, ITimelineClipAsset
	{
		public ContinueConversationBehaviour template;

		public float m_duration;

		public override double duration => 0.0;

		public ClipCaps clipCaps => default(ClipCaps);

		public void SetDuration(float newDuration)
		{
		}

		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}
	}
}
