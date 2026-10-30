using HinputClasses.Internal;

namespace HinputClasses
{
	public class StickPressedZone : StickPressable
	{
		public StickPressedZone(string pressableName, Stick stick)
			: base(null, null)
		{
		}

		protected override bool GetPressed()
		{
			return false;
		}
	}
}
