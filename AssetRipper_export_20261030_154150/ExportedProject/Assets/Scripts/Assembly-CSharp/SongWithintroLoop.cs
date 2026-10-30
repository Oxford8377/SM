using SonicBloom.Koreo;
using UnityEngine;

public class SongWithintroLoop : MonoBehaviour
{
	public AudioSource Intro;

	public AudioSource Loop;

	public Animator dancer;

	public bool SongToLoop;

	[EventID]
	public string Beat;

	private GameObject lastSelected;

	private void Start()
	{
	}

	private void On_Beat(KoreographyEvent evt)
	{
	}

	public void Menu()
	{
	}

	private void Update()
	{
	}
}
