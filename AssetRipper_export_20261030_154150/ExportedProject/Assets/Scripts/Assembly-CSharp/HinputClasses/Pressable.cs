namespace HinputClasses
{
	public abstract class Pressable
	{
		public readonly Gamepad gamepad;

		private bool isPressed;

		private float lastPressStart;

		private float penultimatePressStart;

		public string name { get; protected set; }

		public bool isEnabled { get; private set; }

		public bool pressed => false;

		public bool released => false;

		public bool justPressed => false;

		public bool justReleased => false;

		public float pressDuration => 0f;

		public float releaseDuration => 0f;

		public Press simplePress { get; }

		public Press doublePress { get; }

		public Press longPress { get; }

		public void Enable()
		{
		}

		public void Disable()
		{
		}

		public void Reset()
		{
		}

		public static implicit operator bool(Pressable pressable)
		{
			return false;
		}

		public static implicit operator Press(Pressable pressable)
		{
			return null;
		}

		protected Pressable(Gamepad gamepad, bool isEnabled)
		{
		}

		protected abstract bool GetPressed();

		public virtual void Update()
		{
		}
	}
}
