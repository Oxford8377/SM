using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class BarkGroupMember : MonoBehaviour
	{
		[Tooltip("Member of this group. Can be a Lua expression.")]
		public string groupId;

		[Tooltip("Evaluate Group Id before every bark. Useful if Id is a Lua expression that can change value.")]
		public bool evaluateIdEveryBark;

		[Tooltip("When another group member forces this member's bark to hide, delay this many seconds before hiding.")]
		public float forcedHideDelay;

		[Tooltip("If another group member is barking, wait in a queue to bark instead of cancelling the other member's bark.")]
		public bool queueBarks;

		public float minDelayBetweenQueuedBarks;

		public float maxDelayBetweenQueuedBarks;

		[Tooltip("Hide bark when conversations start.")]
		public bool hideBarkOnConversationStart;

		private string m_currentIdValue;

		private IBarkUI m_barkUI;

		private bool m_applicationIsQuitting;

		public string currentIdValue => null;

		private IBarkUI barkUI => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void OnApplicationQuit()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnConversationStarted(Transform actor)
		{
		}

		public void GroupBark(string conversation, Transform listener, BarkHistory barkHistory, float delayTime = -1f)
		{
		}

		public void GroupBarkString(string barkText, Transform listener, string sequence, float delayTime = -1f)
		{
		}

		private void OnBarkStart(Transform listener)
		{
		}

		public void UpdateMembership()
		{
		}

		public void CancelBark()
		{
		}

		private void HideBarkNow()
		{
		}
	}
}
