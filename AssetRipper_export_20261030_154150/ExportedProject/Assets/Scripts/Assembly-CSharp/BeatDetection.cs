using SonicBloom.Koreo;
using UnityEngine;

public class BeatDetection : MonoBehaviour
{
	public bool onbeat;

	public bool offbeat;

	public bool onbeat2;

	public bool offbeat2;

	[EventID]
	public string Beat;

	[EventID]
	public string Offbeat;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void On_Beat(KoreographyEvent evt)
	{
	}

	private void On_Offbeat(KoreographyEvent evt)
	{
	}
}
