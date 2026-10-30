using Rewired;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettingsMenu : MonoBehaviour
{
	public AudioMixer masterMixer;

	public bool NoRumbleSlider;

	public bool NoVolSlider;

	public Slider mainVolumeSlider;

	public Slider RumbleSlider;

	private bool isMuted;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public float VibLvl;

	private void Start()
	{
	}

	public void ToggleMute(bool toggleValue)
	{
	}

	public void SetMainVolume(float sliderValue)
	{
	}

	public void SaveMenuVariables()
	{
	}

	public void LoadMenuVariables()
	{
	}

	public void SetRumbleIntensity()
	{
	}

	public void ApplyControllerSettings()
	{
	}

	public void ResetToDefault()
	{
	}
}
