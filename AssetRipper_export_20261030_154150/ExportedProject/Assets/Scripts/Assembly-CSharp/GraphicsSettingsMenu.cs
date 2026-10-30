using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GraphicsSettingsMenu : MonoBehaviour
{
	public enum saveFormat
	{
		playerprefs = 0,
		iniFile = 1
	}

	private class MenuVariables
	{
		public int Qualitylevel;

		public bool ShowFPS;

		public int ResolutionX;

		public int ResolutionY;

		public bool WindowedMode;

		public bool VSync;

		public bool LofiWarnings;

		public string Warning;
	}

	public saveFormat saveAs;

	[Tooltip("Check for IOS and Windows Store Apps.")]
	public bool usePersistentDatapath;

	[Header("THESE NEED TO BE DRAGGED IN")]
	public Slider qualityLevelSlider;

	public Text qualityText;

	public GameObject resolutionsPanel;

	public GameObject resButtonPrefab;

	public GameObject menuTransform;

	public Text currentResolutionText;

	public Toggle windowedModeToggle;

	public Toggle vSyncToggle;

	public Toggle dangerToggle;

	private GameObject resolutionsPanelParent;

	private Resolution[] resolutions;

	private bool setMenu;

	private bool openMenu;

	private bool showFPS;

	private bool fullScreenMode;

	private bool toggleVSync;

	private bool DangerWarnings;

	private const float fpsMeasurePeriod = 0.2f;

	private float fpsNextPeriod;

	private float setTextQualDelay;

	public int fpsAccumulator;

	public int currentFps;

	public int wantedResX;

	public int wantedResY;

	private string saveFileDataPath;

	private Coroutine setTextQualityCoR;

	public int lWarn;

	public List<GameObject> ResButtons;

	private MenuVariables saveVars;

	private MenuVariables DefaultSettings;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void Update()
	{
	}

	public void SetQuality()
	{
	}

	public void SetWindowedMode()
	{
	}

	public void SetVSync()
	{
	}

	public void SetDangerWarning()
	{
	}

	private void SetValues()
	{
	}

	public void SetResolution(int index)
	{
	}

	public void ShowResolutionOptions()
	{
	}

	public void SaveMenuVariables()
	{
	}

	private void LoadMenuVariables()
	{
	}

	public void ResetToDefault()
	{
	}
}
