using SonicBloom.Koreo;
using UnityEngine;

public class RhyLine_P : MonoBehaviour
{
	public int blocks;

	public bool lineUp;

	public static int Blocks;

	public static int Blocks2;

	public static int Double;

	public int StartDouble;

	public static bool PlayerSpecific;

	public bool Player;

	public static Vector3[] BobPos;

	public GameObject Block1;

	public GameObject Block2;

	public GameObject Block3;

	public GameObject Block4;

	public GameObject Block5;

	public GameObject Block6;

	public GameObject Block7;

	public GameObject Block8;

	[EventID]
	public string LineStart;

	[EventID]
	public string PlayerLineStart;

	[EventID]
	public string Emergency;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void On_LineStart(KoreographyEvent evt)
	{
	}

	private void On_PLineStart(KoreographyEvent evt)
	{
	}

	private void On_Emergency(KoreographyEvent evt)
	{
	}
}
