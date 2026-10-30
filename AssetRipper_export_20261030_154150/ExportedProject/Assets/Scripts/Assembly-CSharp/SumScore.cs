public class SumScore
{
	private static SumScoreManager mgr;

	public static int Score { get; protected set; }

	public static int HighScore { get; set; }

	private SumScore()
	{
	}

	public static void Add(int pointsToAdd)
	{
	}

	public static void Subtract(int pointsToSubtract)
	{
	}

	public static void Reset()
	{
	}

	private static bool MgrSet()
	{
		return false;
	}

	public static void SaveHighScore()
	{
	}

	public static void ClearHighScore()
	{
	}
}
