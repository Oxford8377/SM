using SonicBloom.Koreo;
using UnityEngine;

public class SongLoop : MonoBehaviour
{
	public AudioSource Intro;

	public AudioSource Loop;

	public bool TitleScreen;

	[EventID]
	public string StartLoop;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void On_StartLoop(KoreographyEvent evt)
	{
	}
}
