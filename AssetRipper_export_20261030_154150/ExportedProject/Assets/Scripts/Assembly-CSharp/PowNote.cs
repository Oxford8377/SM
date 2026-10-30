using Rewired;
using SonicBloom.Koreo;
using UnityEngine;

public class PowNote : MonoBehaviour
{
	public bool Mentor;

	public int PowID;

	public float Placement;

	public float measureDur;

	public float beatDur;

	public float speed;

	public float Time;

	public Animator self;

	public string note;

	public bool Hit;

	public static int PowHits;

	public bool CanHit;

	public AudioSource Sound;

	public GameObject PowRing;

	public int PowOnOff;

	public bool reusable;

	public bool ButtBusy;

	public string CurrentlyOn;

	public static int CurrentPow;

	public int CurrentPowDebug;

	public static bool OnA;

	public static bool OnB;

	public static bool OnX;

	public static bool OnY;

	public static bool OnL;

	public static bool OnR;

	public static bool OnUp;

	public static bool OnDown;

	public static bool OnLeft;

	public static bool OnRight;

	public static bool Try;

	public bool TryDebug;

	[EventID]
	public string Note;

	[EventID]
	public string PowNoteP;

	public int playerId;

	private Player player;

	private CharacterController cc;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void On_Butt(KoreographyEvent evt)
	{
	}

	private void On_PowNoteP(KoreographyEvent evt)
	{
	}

	private void OnTriggerEnter2D(Collider2D coll)
	{
	}

	private void OnTriggerExit2D(Collider2D coll)
	{
	}

	public static void PowNotif()
	{
	}

	public void Pow()
	{
	}
}
