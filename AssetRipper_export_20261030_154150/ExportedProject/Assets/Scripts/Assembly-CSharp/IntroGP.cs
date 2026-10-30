using SonicBloom.Koreo;
using UnityEngine;

public class IntroGP : MonoBehaviour
{
	public bool Door;

	public int HW;

	public Animator door1;

	public Animator door2;

	public GameObject Synth;

	public GameObject Mel;

	public GameObject SillyWalk;

	public GameObject HandWash;

	public GameObject BuildingBounce;

	public Animator MainCam;

	public GameObject LookIt;

	public GameObject Scene1;

	public GameObject Scene0;

	public GameObject Clock;

	public GameObject Customers;

	public Camera camera1;

	public Camera camera2;

	public bool Luigi;

	public int readycount;

	[EventID]
	public string DoorOpen;

	[EventID]
	public string DoorOpen1;

	[EventID]
	public string SillyWalky;

	[EventID]
	public string HandWashin;

	[EventID]
	public string GetReady;

	private void Start()
	{
	}

	private void On_DoorOpen(KoreographyEvent evt)
	{
	}

	private void On_DoorOpen1(KoreographyEvent evt)
	{
	}

	private void On_SillyWalk(KoreographyEvent evt)
	{
	}

	private void On_HandWash(KoreographyEvent evt)
	{
	}

	private void On_GetReady(KoreographyEvent evt)
	{
	}

	private void Update()
	{
	}
}
