using System.Collections.Generic;
using UnityEngine;

namespace HinputClasses.Internal
{
	public class AnyGamepadStick : Stick
	{
		private readonly List<Stick> sticks;

		public AnyGamepadStick(string stickName, Gamepad gamepad, int index)
			: base(null, null, 0, isEnabled: false)
		{
		}

		protected override Vector2 GetPosition()
		{
			return default(Vector2);
		}
	}
}
