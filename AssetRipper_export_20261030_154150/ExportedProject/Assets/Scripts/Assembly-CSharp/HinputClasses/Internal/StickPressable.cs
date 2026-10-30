namespace HinputClasses.Internal
{
	public abstract class StickPressable : Pressable
	{
		public readonly Stick stick;

		protected StickPressable(string pressableName, Stick stick)
			: base(null, isEnabled: false)
		{
		}
	}
}
