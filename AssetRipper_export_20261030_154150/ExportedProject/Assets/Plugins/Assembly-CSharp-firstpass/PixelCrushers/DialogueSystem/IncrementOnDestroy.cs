using UnityEngine;
using UnityEngine.Events;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class IncrementOnDestroy : MonoBehaviour
	{
		public enum IncrementOn
		{
			Destroy = 0,
			Disable = 1,
			Manually = 2
		}

		[Tooltip("Increment on Destroy or Disable.")]
		public IncrementOn incrementOn;

		[VariablePopup(true)]
		[Tooltip("Increment this Dialogue System variable.")]
		public string variable;

		[Tooltip("Increment the variable by this amount. Use a negative value to decrement.")]
		public int increment;

		[Tooltip("After incrementing, ensure that the variable is at least this value.")]
		public int min;

		[Tooltip("After incrementing, ensure that the variable is no more than this value.")]
		public int max;

		[Tooltip("Optional alert message to show when incrementing.")]
		public string alertMessage;

		[Tooltip("Duration to show alert, or 0 to use default duration.")]
		public float alertDuration;

		[Tooltip("If set, only increment if the conditions are true.")]
		public Condition condition;

		public UnityEvent onIncrement;

		protected bool listenForOnDestroy;

		protected bool awakeMarkedForDestroy;

		protected virtual string actualVariableName => null;

		protected string ActualVariableName => null;

		protected virtual void Awake()
		{
		}

		public virtual void OnEnable()
		{
		}

		public virtual void OnLevelWillBeUnloaded()
		{
		}

		public virtual void OnApplicationQuit()
		{
		}

		public virtual void OnDestroy()
		{
		}

		public virtual void OnDisable()
		{
		}

		public virtual void TryIncrement()
		{
		}

		protected virtual bool CanIncrement()
		{
			return false;
		}

		protected virtual void IncrementNow()
		{
		}
	}
}
