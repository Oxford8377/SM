using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[Serializable]
	public class UnityUIResponseMenuControls : AbstractUIResponseMenuControls
	{
		[Tooltip("The panel containing the response menu controls. A panel is optional, but you may want one so you can include a background image, panel-wide effects, etc.")]
		public Graphic panel;

		[Tooltip("The PC portrait image to show during the response menu.")]
		public Image pcImage;

		[Tooltip("The label that will show the PC name.")]
		public Text pcName;

		[Tooltip("The reminder of the last subtitle.")]
		public UnityUISubtitleControls subtitleReminder;

		[Tooltip("The (optional) timer.")]
		public Slider timer;

		[Tooltip("Select the currently-focused response on timeout.")]
		public bool selectCurrentOnTimeout;

		[Tooltip("Design-time positioned response buttons")]
		public UnityUIResponseButton[] buttons;

		[Tooltip("Template from which to instantiate response buttons; optional to use instead of positioned buttons above")]
		public UnityUIResponseButton buttonTemplate;

		[Tooltip("If using Button Template, instantiated buttons are parented under this GameObject")]
		public Graphic buttonTemplateHolder;

		[Tooltip("Optional scrollbar if the instantiated button holder is in a scroll rect")]
		public Scrollbar buttonTemplateScrollbar;

		[Tooltip("Reset the scroll bar to this value when preparing the response menu")]
		public float buttonTemplateScrollbarResetValue;

		[Tooltip("Automatically set up explicit navigation for instantiated template buttons instead of using Automatic navigation")]
		public bool explicitNavigationForTemplateButtons;

		[Tooltip("If explicit navigation is enabled, loop around when navigating past end of menu")]
		public bool loopExplicitNavigation;

		public UIAutonumberSettings autonumber;

		public UIAnimationTransitions animationTransitions;

		public UnityEvent onContentChanged;

		[HideInInspector]
		public List<GameObject> instantiatedButtons;

		public Action TimeoutHandler;

		private UIShowHideController m_showHideController;

		private UnityUITimer unityUITimer;

		private Sprite pcPortraitSprite;

		private string pcPortraitName;

		private Animator animator;

		private bool lookedForAnimator;

		public bool isVisible => false;

		public UIShowHideController showHideController => null;

		public override AbstractUISubtitleControls subtitleReminderControls => null;

		public override void SetPCPortrait(Sprite portraitSprite, string portraitName)
		{
		}

		public override void SetActorPortraitSprite(string actorName, Sprite portraitSprite)
		{
		}

		public override void SetActive(bool value)
		{
		}

		private void DeactivateUIElements()
		{
		}

		protected override void ClearResponseButtons()
		{
		}

		protected override void SetResponseButtons(Response[] responses, Transform target)
		{
		}

		private void SetResponseButton(UnityUIResponseButton button, Response response, Transform target, int buttonNumber)
		{
		}

		private int GetNextAvailableResponseButtonPosition(int start, int direction)
		{
			return 0;
		}

		public void SetupTemplateButtonNavigation()
		{
		}

		public void DestroyInstantiatedButtons()
		{
		}

		public void NotifyContentChanged()
		{
		}

		public override void StartTimer(float timeout)
		{
		}

		public virtual void OnTimeout()
		{
		}

		public void DefaultTimeoutHandler()
		{
		}

		public void AutoFocus(GameObject lastSelection = null, bool allowStealFocus = true)
		{
		}

		private bool CanTriggerAnimation(string triggerName)
		{
			return false;
		}

		private bool CanTriggerAnimations()
		{
			return false;
		}
	}
}
