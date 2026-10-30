using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public abstract class BarkStarter : ConversationStarter
	{
		[Tooltip("The order in which to bark dialogue entries.")]
		public BarkOrder barkOrder;

		[Tooltip("Allow barks during active conversations.")]
		public bool allowDuringConversations;

		[Tooltip("Cache all lines during first bark. This can reduce stutter when barking on slower mobile devices, but barks' conditions are not reevaluated each time as the state changes, barks use no em formatting codes, and sequences are not played with barks.")]
		public bool cacheBarkLines;

		private BarkHistory barkHistory;

		private bool tryingToBark;

		private ConversationState cachedState;

		private IBarkUI barkUI;

		protected BarkGroupMember barkGroupMember;

		public Sequencer sequencer { get; private set; }

		public int BarkIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void TryBark(Transform target)
		{
		}

		public void TryBark(Transform target, Transform interactor)
		{
		}

		private Transform GetBarker()
		{
			return null;
		}

		private string GetBarkerName()
		{
			return null;
		}

		private void BarkCachedLine(Transform speaker, Transform listener)
		{
		}

		private void PopulateCache(Transform speaker, Transform listener)
		{
		}

		private void BarkNextCachedLine(Transform speaker, Transform listener)
		{
		}

		public void ResetBarkHistory()
		{
		}

		public void OnRecordPersistentData()
		{
		}

		public void OnApplyPersistentData()
		{
		}
	}
}
