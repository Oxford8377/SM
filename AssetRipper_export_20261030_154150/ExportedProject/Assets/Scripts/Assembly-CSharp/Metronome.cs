using Rewired;
using SonicBloom.Koreo;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Metronome : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public AudioListener Listener;

	public Animator Tick1;

	public Animator Tick2;

	public Animator Tick3;

	public Animator Tick4;

	public int tick;

	public TextMeshProUGUI VisMs;

	public Slider VDslider;

	public float NewDelayMs;

	public float defaultValue;

	public GameObject StoryNext;

	public GameObject Next;

	public int story;

	public static bool OptMenu;

	public string CurrentScene;

	[EventID]
	public string Beat1;

	[EventID]
	public string Beat2;

	[EventID]
	public string Beat3;

	[EventID]
	public string Beat4;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetNewDelay(float newDelay)
	{
	}

	private void On_Beat1(KoreographyEvent evt)
	{
	}

	private void On_Beat2(KoreographyEvent evt)
	{
	}

	private void On_Beat3(KoreographyEvent evt)
	{
	}

	private void On_Beat4(KoreographyEvent evt)
	{
	}
}
