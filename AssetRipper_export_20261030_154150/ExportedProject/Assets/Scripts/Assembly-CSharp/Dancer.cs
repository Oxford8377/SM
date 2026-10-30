using SonicBloom.Koreo;
using UnityEngine;

public class Dancer : MonoBehaviour
{
	public bool AutoSelf;

	public bool Half;

	public bool Quarter;

	public Animator dancer;

	public int BeatCount;

	public string Trigger;

	[EventID]
	public string Beat;

	private void Start()
	{
	}

	private void On_Beat(KoreographyEvent evt)
	{
	}

	private void Update()
	{
	}
}
