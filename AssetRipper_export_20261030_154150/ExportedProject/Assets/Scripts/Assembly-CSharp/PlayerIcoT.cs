using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using SonicBloom.Koreo;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerIcoT : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CQuitGame_003Ed__322 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerIcoT _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CQuitGame_003Ed__322(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CReturntogame_003Ed__324 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerIcoT _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CReturntogame_003Ed__324(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public GameObject LevelBegin;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public float VibLvl;

	public int LofiWarning;

	public bool InStory;

	public int story;

	public List<GameObject> NoteClones;

	public int Dots;

	public float PressesAllowed;

	public float IPS;

	public float IPSLimit;

	public float IPSLimitOG;

	public float IPSLimitFS;

	public bool CheckingIPS;

	public bool spamming;

	public int NoMoreLimit;

	public float ButtPresses;

	public bool BlueLine;

	public bool PinkLine;

	public static bool BlueLine1;

	public static bool PinkLine1;

	public Animator RhyBox;

	public Animator RhyCircle;

	public ParticleSystem Trail;

	public Camera MainCam;

	public Text DebugButtneed;

	public GameObject GameOver;

	public GameObject DANGER;

	public GameObject Breather;

	public GameObject Scene1obj;

	public GameObject Scene2;

	public GameObject GameOpress;

	public AudioSource DangerBeat;

	public int ACP;

	public int ACP2;

	public int funkneeded;

	public int funkneededOG;

	public int ACPneeded;

	public int ACPneededOG;

	public int grooveneeded;

	public int grooveneededOG;

	public int funk;

	public int style;

	public int rebel;

	public int rebelCombo;

	public bool RCadded;

	public bool obedient;

	private bool active;

	private bool active2;

	public bool ButtBusy;

	public bool GrooveReady;

	public GameObject Fryer;

	public GameObject Fryer2;

	public bool gamePaused;

	public bool InOptions;

	public AudioSource Instrumental;

	public GameObject Menu;

	public Animator Fidelity;

	public GameObject FreeMode;

	public bool FreeStyle;

	public AudioSource freeIntro;

	public AudioSource freeLoop;

	public AudioSource badend;

	public AudioSource twLoop;

	public GameObject freeLoop_obj;

	public GameObject MentorVoice;

	public GameObject note_A;

	public GameObject note_ZL;

	public GameObject note_ZR;

	public GameObject note_B;

	public GameObject note_Y;

	public GameObject note_X;

	public GameObject note_up;

	public GameObject note_down;

	public GameObject note_left;

	public GameObject note_right;

	public GameObject sparkleB;

	public GameObject sparkleR;

	public AudioSource voice;

	public AudioSource scratch;

	public Animator CurrentAnimator;

	public Animator PlayerFree;

	public Animator PlayerL1;

	public Animator PlayerL2;

	public Animator PlayerL3;

	public Animator funknob;

	public Animator Scene1;

	public TextMeshProUGUI caption;

	public TextMeshProUGUI ScoreAdd;

	public TextMeshProUGUI ScoreSub;

	public int ButtsNeeded;

	public int NoteAmount;

	public Slider FunkSlider;

	public Slider ACPSlider;

	public Slider FunkDial;

	public Slider StyleDial;

	public Slider ACPDial;

	public GameObject Glow;

	public GameObject top_flipper;

	public GameObject bottom_flipper;

	public float line;

	public float groovycount;

	public float badcount;

	public GUI scoreText;

	public float rhyths;

	public bool onbackbeat;

	public bool onbeat;

	public bool onstarbeat;

	public bool offbeat;

	public bool offbackbeat;

	public bool offstarbeat;

	public bool offanybeat;

	public bool onanybeat;

	public bool good;

	public bool groovy;

	public bool pressUp;

	public bool pressDown;

	public bool pressRight;

	public bool pressLeft;

	public bool pressZL;

	public bool pressZR;

	public bool ZLdown;

	public bool ZRdown;

	public AudioSource ScoreSounds;

	public AudioClip good1;

	public AudioClip bad1;

	public ParticleSystem burstin;

	public float Speed;

	public float Butt2Presses;

	public float Butt1Presses;

	public float Butt3Presses;

	public float Butt4Presses;

	public float LeftPresses;

	public float RightPresses;

	public float DownPresses;

	public float UpPresses;

	public float ZLPresses;

	public float ZRPresses;

	public string ObedientButton;

	public static bool CanA;

	public static int Aclips;

	public static bool CanB;

	public static int Bclips;

	public static bool CanX;

	public static int Xclips;

	public static bool CanY;

	public static int Yclips;

	public static bool CanL;

	public static int Lclips;

	public static bool CanR;

	public static int Rclips;

	public static bool CanUp;

	public static int Upclips;

	public static bool CanDown;

	public static int Downclips;

	public static bool CanLeft;

	public static int Leftclips;

	public static bool CanRight;

	public static int Rightclips;

	public AudioClip p1;

	public AudioClip p2;

	public AudioClip p3;

	public AudioClip p4;

	public AudioClip p5;

	public AudioClip p6;

	public AudioClip p7;

	public AudioClip p8;

	public AudioClip p9;

	public AudioClip p10;

	public AudioClip p11;

	public AudioClip p12;

	public AudioClip p13;

	public AudioClip p14;

	public AudioClip p15;

	public AudioClip p16;

	public AudioClip p17;

	public AudioClip p18;

	public AudioClip p19;

	public AudioClip p20;

	public AudioClip p21;

	public AudioClip p22;

	public AudioClip p23;

	public AudioClip p24;

	public AudioClip p25;

	public AudioClip p26;

	public AudioClip p27;

	public AudioClip p28;

	public AudioClip p29;

	public AudioClip p30;

	public AudioClip p31;

	public AudioClip p32;

	public AudioClip p33;

	public AudioClip p34;

	public AudioClip p35;

	public AudioClip p36;

	public AudioClip p37;

	public AudioClip p38;

	public AudioClip p39;

	public AudioClip p40;

	public AudioClip p41;

	public AudioClip p42;

	public AudioClip p43;

	public AudioClip p44;

	public AudioClip p45;

	public AudioClip p46;

	public AudioClip p47;

	public AudioClip p48;

	public AudioClip p49;

	public AudioClip p50;

	public AudioClip p51;

	public AudioClip p52;

	public AudioClip p53;

	public AudioClip p54;

	public AudioClip p55;

	public AudioClip p56;

	public AudioClip p57;

	public AudioClip p58;

	public AudioClip p59;

	public AudioClip p60;

	public AudioClip p61;

	public AudioClip p62;

	public AudioClip p63;

	public AudioClip p64;

	public AudioClip p65;

	public AudioClip p66;

	public AudioClip p67;

	public AudioClip p68;

	public AudioClip p69;

	public AudioClip p70;

	public AudioClip p71;

	public AudioClip p72;

	public AudioClip p73;

	public AudioClip p74;

	public AudioClip p75;

	public AudioClip p76;

	public AudioClip p77;

	public AudioClip p78;

	public AudioClip p79;

	public AudioClip p80;

	public AudioClip p81;

	public AudioClip p82;

	public AudioClip p83;

	public AudioClip p84;

	public AudioClip p85;

	public AudioClip p86;

	public AudioClip miss;

	private Animator anim;

	public Animator lowflipper;

	public Animator highflipper;

	public Animator mentor;

	public GameObject FadeOff;

	public GameObject Goodbye;

	public AudioSource Up;

	public AudioSource Up2;

	public AudioSource Up3;

	public AudioSource Up4;

	public AudioSource Down;

	public AudioSource Down2;

	public AudioSource Down3;

	public AudioSource Down4;

	public AudioSource Left;

	public AudioSource Left2;

	public AudioSource Left3;

	public AudioSource Left4;

	public AudioSource Right;

	public AudioSource Right2;

	public AudioSource Right3;

	public AudioSource Right4;

	public AudioSource A;

	public AudioSource A2;

	public AudioSource A3;

	public AudioSource A4;

	public AudioSource B;

	public AudioSource B2;

	public AudioSource B3;

	public AudioSource B4;

	public AudioSource X;

	public AudioSource X2;

	public AudioSource X3;

	public AudioSource X4;

	public AudioSource X5;

	public AudioSource Y;

	public AudioSource Y2;

	public AudioSource Y3;

	public AudioSource Y4;

	public AudioSource L;

	public AudioSource L2;

	public AudioSource L3;

	public AudioSource L4;

	public AudioSource R;

	public AudioSource R2;

	public AudioSource R3;

	public AudioSource R4;

	[EventID]
	public string LineStart;

	[EventID]
	public string LineEnd;

	[EventID]
	public string LineNext;

	[EventID]
	public string GroovyStart;

	[EventID]
	public string Starbeat;

	[EventID]
	public string EndSong;

	[EventID]
	public string Note;

	[EventID]
	public string Perfect_Blue;

	public int AllFunk;

	public int AllFunkSmall;

	public static bool S_Eligible;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void On_EndSong(KoreographyEvent evt)
	{
	}

	private void On_LineStart(KoreographyEvent evt)
	{
	}

	private void On_NextLine(KoreographyEvent evt)
	{
	}

	private void On_LineEnd(KoreographyEvent evt)
	{
	}

	private void TrainWreck()
	{
	}

	private void GrooveMode()
	{
	}

	private void On_GroovyStart(KoreographyEvent evt)
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	public void AddPoints(int points)
	{
	}

	private void KillNotes()
	{
	}

	private void LoseGroove()
	{
	}

	public void Retry()
	{
	}

	public void Quit()
	{
	}

	[IteratorStateMachine(typeof(_003CQuitGame_003Ed__322))]
	private IEnumerator QuitGame()
	{
		return null;
	}

	public void Resume()
	{
	}

	[IteratorStateMachine(typeof(_003CReturntogame_003Ed__324))]
	private IEnumerator Returntogame()
	{
		return null;
	}

	public void ACPsliderAdj()
	{
	}

	public void OnBeatPoints()
	{
	}

	public void OffbeatPoints()
	{
	}

	public void OnPinkPoints()
	{
	}

	private void On_Starbeat(KoreographyEvent evt)
	{
	}

	private void On_Perfect_Blue(KoreographyEvent evt)
	{
	}

	private void On_ButtP(KoreographyEvent evt)
	{
	}

	public void OptionsOpen()
	{
	}

	public void OptionsClosed()
	{
	}
}
