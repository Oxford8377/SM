using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SumScoreManager : MonoBehaviour
{
	public static SumScoreManager instance;

	public int initialScore;

	public bool storeHighScore;

	public bool allowNegative;

	public TextMeshProUGUI field;

	public Text highScoreField;

	public static int NoteAmount;

	public static int PinkNoteAmount;

	public static bool Butt1Needed;

	public static bool Butt2Needed;

	public static bool Butt3Needed;

	public static bool Butt4Needed;

	public static bool UpNeeded;

	public static bool DownNeeded;

	public static bool LeftNeeded;

	public static bool RightNeeded;

	public static bool ZRNeeded;

	public static bool ZLNeeded;

	public static int ButtsNeeded;

	public static bool CanA;

	public static int Aclips;

	public static bool CanB;

	public static int Bclips;

	public static bool CanX;

	public static int Xclips;

	public static bool CanY;

	public static int Yclips;

	public static bool CanL;

	public static int Lclips;

	public static bool CanR;

	public static int Rclips;

	public static bool CanUp;

	public static int Upclips;

	public static bool CanDown;

	public static int Downclips;

	public static bool CanLeft;

	public static int Leftclips;

	public static bool CanRight;

	public static int Rightclips;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public static void ClearCans()
	{
	}

	public void Updated()
	{
	}

	public void UpdatedHS()
	{
	}
}
