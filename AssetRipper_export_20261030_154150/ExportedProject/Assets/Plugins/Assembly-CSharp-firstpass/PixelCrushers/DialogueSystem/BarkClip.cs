using System;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class BarkClip : PlayableAsset, ITimelineClipAsset
	{
		public BarkBehaviour template;

		public ExposedReference<Transform> listener;

		public ClipCaps clipCaps => default(ClipCaps);

		public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			return default(Playable);
		}
	}
}
