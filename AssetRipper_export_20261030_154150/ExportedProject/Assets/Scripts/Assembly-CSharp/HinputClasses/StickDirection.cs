using HinputClasses.Internal;

namespace HinputClasses
{
	public class StickDirection : StickPressable
	{
		private float angle { get; }

		public StickDirection(string pressableName, float angle, Stick stick)
			: base(null, null)
		{
		}

		protected override bool GetPressed()
		{
			return false;
		}
	}
}
