using HinputClasses.Internal;

namespace HinputClasses
{
	public class Button : GamepadPressable
	{
		public Button(string pressableName, Gamepad gamepad, int index, bool isEnabled)
			: base(null, null, 0, isEnabled: false)
		{
		}

		protected override bool GetPressed()
		{
			return false;
		}
	}
}
