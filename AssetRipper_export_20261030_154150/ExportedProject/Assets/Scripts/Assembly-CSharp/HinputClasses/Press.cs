namespace HinputClasses
{
	public class Press
	{
		public Pressable button;

		public Gamepad gamepad;

		private int lastPressedFrame;

		private int lastReleasedFrame;

		private float lastPressed;

		private float lastReleased;

		public bool pressed { get; private set; }

		public bool released => false;

		public bool justPressed => false;

		public bool justReleased => false;

		public float pressDuration => 0f;

		public float releaseDuration => 0f;

		public static implicit operator bool(Press press)
		{
			return false;
		}

		public Press(Pressable button)
		{
		}

		public void Update(bool isPressed)
		{
		}
	}
}
