using Rewired;
using TMPro;
using UnityEngine;

public class LevelSelect : MonoBehaviour
{
	public string CurrentScene;

	public bool DontUpdateCurrentScene;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public bool LevelJumper;

	public string SceneName;

	public int LevelsUnlocked;

	public int LastLevel;

	public int LastLevelStory;

	public GameObject LVL1scr;

	public static int Level;

	public static bool InStory;

	public bool OptMenu;

	public bool InHub;

	public GameObject ClearSaveButton;

	public static bool CanClear;

	public GameObject BGMusic;

	public AudioListener OptAudio;

	public GameObject OptLight;

	public bool ActualScene;

	public int SaveFile;

	public int defaultValue;

	public Animator DifficIcon;

	public string Difficulty;

	public int diffiValue;

	public GameObject DifficultyMenu;

	public GameObject QGclose;

	public bool ChangingDiff;

	public bool StoryMode;

	public int story;

	public static bool DemoCompleted;

	public bool DemoComplete;

	public GameObject StoryWarning;

	public GameObject MenuEventSystem;

	public GameObject TitleMusic;

	public bool TitleScene;

	public AudioSource NoWay;

	public GameObject CalibrationExit;

	public GameObject OptionsMenu;

	public GameObject LVL0;

	public GameObject Riv1;

	public GameObject Riv2;

	public GameObject Riv3;

	public GameObject LVL1;

	public GameObject A2Riv1;

	public GameObject A2Riv2;

	public GameObject A2Riv3;

	public GameObject A2Boss;

	public TextMeshProUGUI DiffiTxt;

	public TextMeshProUGUI Riv1HS;

	public TextMeshProUGUI Riv2HS;

	public TextMeshProUGUI Riv3HS;

	public TextMeshProUGUI Riv4HS;

	public TextMeshProUGUI LVL1HS;

	public TextMeshProUGUI A2Riv1HS;

	public TextMeshProUGUI A2Riv2HS;

	private void Start()
	{
	}

	public void Awake()
	{
	}

	public void Quit()
	{
	}

	public void CloseGame()
	{
	}

	public void Go_Options()
	{
	}

	public void Bye_Options()
	{
	}

	public void Go_LvLSelect()
	{
	}

	public void Go_LvLSelectAct2()
	{
	}

	public void Bye_LvLSelect()
	{
	}

	public void Go_Story()
	{
	}

	public void Go_JamWell()
	{
	}

	public void Clear_Story()
	{
	}

	public void Go_LvL0()
	{
	}

	public void Go_RvL1()
	{
	}

	public void Go_RvL2()
	{
	}

	public void Go_RvL3()
	{
	}

	public void Go_LvL1()
	{
	}

	public void Go_A2RvL1()
	{
	}

	public void Go_A2RvL2()
	{
	}

	public void Go_A2RvL3()
	{
	}

	public void ClearData()
	{
	}

	public void Go_Title()
	{
	}

	public void Go_Calibrate()
	{
	}

	public void Enable_Music()
	{
	}

	public void DisableBackButtons()
	{
	}

	public void EnableBackButtons()
	{
	}

	public void SetEasy()
	{
	}

	public void SetNormal()
	{
	}

	public void RiseDifficulty()
	{
	}

	public void LowerDifficulty()
	{
	}

	private void Update()
	{
	}

	public void JumpLevel()
	{
	}

	public void DifficultySelectHubWorld()
	{
	}
}
