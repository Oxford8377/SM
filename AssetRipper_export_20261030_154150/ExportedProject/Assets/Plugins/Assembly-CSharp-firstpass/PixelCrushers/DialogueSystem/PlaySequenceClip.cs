using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class PlaySequenceClip : PlayableAsset, ITimelineClipAsset
	{
		public PlaySequenceBehaviour template;

		public ExposedReference<Transform> listener;

		public ClipCaps clipCaps => default(ClipCaps);

		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}
	}
}
