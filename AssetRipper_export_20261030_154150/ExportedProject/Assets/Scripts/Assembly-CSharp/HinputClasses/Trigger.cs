using HinputClasses.Internal;

namespace HinputClasses
{
	public class Trigger : GamepadPressable
	{
		private readonly float initialValue;

		private bool hasBeenMoved;

		private float measuredPosition => 0f;

		public float position { get; private set; }

		public Trigger(string pressableName, Gamepad gamepad, int index, bool isEnabled)
			: base(null, null, 0, isEnabled: false)
		{
		}

		public override void Update()
		{
		}

		private float GetPosition()
		{
			return 0f;
		}

		protected override bool GetPressed()
		{
			return false;
		}
	}
}
