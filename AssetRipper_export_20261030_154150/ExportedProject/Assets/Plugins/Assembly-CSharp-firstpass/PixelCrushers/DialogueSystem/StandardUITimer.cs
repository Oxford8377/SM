using System;
using UnityEngine;
using UnityEngine.UI;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class StandardUITimer : MonoBehaviour
	{
		private Slider slider;

		private bool m_isCountingDown;

		private float m_startTime;

		private float m_duration;

		private Action m_timeoutHandler;

		public virtual void Awake()
		{
		}

		public virtual void StartCountdown(float duration, Action timeoutHandler)
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void StopCountdown()
		{
		}

		public void SkipTime(float amountToSkip)
		{
		}

		public virtual void UpdateTimeLeft(float normalizedTimeLeft)
		{
		}
	}
}
