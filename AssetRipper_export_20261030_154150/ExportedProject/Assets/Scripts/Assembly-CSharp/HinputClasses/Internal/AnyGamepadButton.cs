using System.Collections.Generic;

namespace HinputClasses.Internal
{
	public class AnyGamepadButton : Button
	{
		private readonly List<Pressable> buttons;

		public AnyGamepadButton(string pressableName, Gamepad gamepad, int index, bool isEnabled)
			: base(null, null, 0, isEnabled: false)
		{
		}

		protected override bool GetPressed()
		{
			return false;
		}
	}
}
