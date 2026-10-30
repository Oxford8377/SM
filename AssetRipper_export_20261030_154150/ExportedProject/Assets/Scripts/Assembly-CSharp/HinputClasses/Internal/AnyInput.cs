using System.Collections.Generic;

namespace HinputClasses.Internal
{
	public class AnyInput : GamepadPressable
	{
		private readonly List<Pressable> inputs;

		public AnyInput(string pressableName, Gamepad gamepad, bool isEnabled)
			: base(null, null, 0, isEnabled: false)
		{
		}

		protected override bool GetPressed()
		{
			return false;
		}
	}
}
