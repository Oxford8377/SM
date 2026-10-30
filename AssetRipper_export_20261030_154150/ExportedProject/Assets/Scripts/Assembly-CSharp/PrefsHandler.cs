using Rewired;
using UnityEngine;
using UnityEngine.UI;

public class PrefsHandler : MonoBehaviour
{
	public bool TitleScreen;

	public bool NoTogglesNeeded;

	public int CTRlayout;

	public Toggle KB_Toggle;

	public Toggle XB_Toggle;

	public Toggle PS_Toggle;

	public Toggle NS_Toggle;

	public Toggle GEN_Toggle;

	public Toggle Auto_Toggle;

	public int Automatic;

	public Animator ManualToggles;

	public GameObject KBToggle;

	public GameObject XBToggle;

	public GameObject PSToggle;

	public GameObject NSToggle;

	public GameObject GENToggle;

	public static bool CanPause;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public static float SVMS;

	public static float SVD;

	public static float PVMS;

	public static float PVD;

	public float VibCorrection;

	private GameObject lastSelected;

	private void Start()
	{
	}

	public void XB()
	{
	}

	public void PS()
	{
	}

	public void NS()
	{
	}

	public void KB()
	{
	}

	public void GEN()
	{
	}

	public void Auto()
	{
	}

	public void NotInStory()
	{
	}

	public void InStory()
	{
	}

	public void ClearData()
	{
	}

	public void OpenOptions()
	{
	}

	private void Update()
	{
	}

	public void ControllerCheck()
	{
	}

	public void ControlsTab()
	{
	}
}
