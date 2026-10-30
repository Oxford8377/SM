using Rewired;
using UnityEngine;

namespace PixelCrushers.DialogueSystem.RewiredSupport
{
	[AddComponentMenu("Pixel Crushers/Dialogue System/Third Party/Rewired/Dialogue System Rewired")]
	public class DialogueSystemRewired : MonoBehaviour
	{
		[Tooltip("Rewired player ID.")]
		public int playerId;

		private Player m_player;

		private void Start()
		{
		}

		public bool RewiredGetButtonDown(string buttonName)
		{
			return false;
		}
	}
}
