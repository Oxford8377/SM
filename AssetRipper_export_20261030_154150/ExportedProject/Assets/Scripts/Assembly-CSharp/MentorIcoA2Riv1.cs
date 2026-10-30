using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using SonicBloom.Koreo;
using SonicBloom.Koreo.Players;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MentorIcoA2Riv1 : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGiveRank_003Ed__316 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MentorIcoA2Riv1 _003C_003E4__this;

		private int _003Crank_003E5__2;

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
		public _003CGiveRank_003Ed__316(int _003C_003E1__state)
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
	private sealed class _003CBonus_003Ed__317 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MentorIcoA2Riv1 _003C_003E4__this;

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
		public _003CBonus_003Ed__317(int _003C_003E1__state)
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
	private sealed class _003CWaitForTS_003Ed__321 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MentorIcoA2Riv1 _003C_003E4__this;

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
		public _003CWaitForTS_003Ed__321(int _003C_003E1__state)
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

	public bool DebugMode;

	public bool OneShotSounds;

	public string Difficulty;

	public static string Difficulty2;

	public SimpleMusicPlayer MusicPlayer;

	public Koreography Easy;

	public Koreography Normal;

	public Koreography Hard;

	public GameObject Pauser;

	public bool InStory;

	public int story;

	public int SaveFile;

	public bool FirstTime;

	public Animator ZoneCard;

	public Animator RhyBox;

	public Animator RhyCircle;

	public bool BlueLine;

	public bool PinkLine;

	public bool DoubleLineNext;

	public Animator Rep;

	public Animator Sup;

	public Animator Double;

	public Animator NextLine;

	public Animator NextLine2;

	public Animator NextLineWhole;

	public AudioSource ColorSwap;

	public GameObject playerico;

	public Animator PlayerIco;

	public GameObject Danny;

	public List<GameObject> Phantoms;

	public ParticleSystem Trail;

	public int ExtraCount;

	public int IntroCount;

	public static int MentorFunkneeded;

	public GameObject Line1Pow;

	public GameObject Line7Pow;

	public GameObject Line8Pow;

	public GameObject Line9Pow;

	public GameObject Line13P;

	public GameObject Line14P;

	public List<GameObject> NoteClones;

	public Vector3[] NotePos;

	public int CurrentNote;

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

	public GameObject Rhybox;

	public GameObject IntroVid;

	public GameObject IntroScene;

	public GameObject Scene1;

	public GameObject Scene1cam;

	public Animator Scene1Cam;

	public GameObject Scene2;

	public GameObject Scene3;

	public GameObject Scene4;

	public GameObject Scene5;

	public GameObject EndScene;

	public TextMeshProUGUI caption;

	public Animator PlayerL1;

	public Animator PlayerL2;

	public Animator PlayerPos;

	public Animator MentorL1;

	public Animator MentorL1Rec;

	public Animator MentorBL1;

	public Animator MentorBL1Rec;

	public Animator MentorL2;

	public Animator MentorBL2;

	public Animator MentorL3;

	public Animator MentorL4;

	public Animator MentorL5;

	public Animator TenBall;

	public GameObject BCC;

	public GameObject BCCbg;

	public GameObject Jamtine;

	public Animator Sign;

	public TextMeshProUGUI P1points;

	public TextMeshProUGUI P2points;

	public int SprayMove;

	public Animator camera;

	public bool done;

	public float Speed;

	public AudioSource Song;

	private bool active;

	public Animator lowflipper;

	public Animator highflipper;

	public Animator self;

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

	public int Line;

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

	public AudioClip none;

	public AudioSource voice;

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
	public string Note;

	[EventID]
	public string LineStart;

	[EventID]
	public string LineEnd;

	[EventID]
	public string LineNext;

	[EventID]
	public string PlayerLineStart;

	[EventID]
	public string PlayerLineEnd;

	[EventID]
	public string Intro;

	[EventID]
	public string Extra;

	[EventID]
	public string EndSong;

	[EventID]
	public string Warning;

	[EventID]
	public string Ball;

	public Slider ResultsSlider;

	public GameObject Funkcount;

	public GameObject Stylecount;

	public GameObject ACPcount;

	public GameObject Totalcount;

	public TextMeshProUGUI ResTotal;

	public int TotalScore;

	public GameObject Rewards;

	public bool ResultsTime;

	public GameObject Results;

	public AudioSource tick;

	public int StyleAdded;

	public int FunkAdded;

	public int ACPAdded;

	public bool Funkdone;

	public bool Styledone;

	public bool ACPdone;

	public Canvas UIjunk;

	public GameObject UIjunk1;

	public GameObject HiFiBonus;

	public GameObject PerfectBonus;

	public GameObject WoahFiBonus;

	public GameObject RhyCam;

	public bool BonusAdded;

	public bool Bonus2Added;

	public Animator MelodiiRes;

	public GameObject Srank;

	public GameObject Arank;

	public GameObject Brank;

	public GameObject Crank;

	public GameObject Drank;

	public bool Perfect;

	public int S_value;

	public int A_value;

	public int B_value;

	public int C_value;

	public int D_value;

	public bool NewRecord;

	public GameObject NewRecordSplash;

	public float highScore;

	public float defaultValue;

	private float firstTime;

	public GameObject ResultsTheme;

	public GameObject CloseReg;

	public GameObject CloseStory;

	public GameObject ResultsSkipper;

	public Animator RankRecord;

	public Animator RankColor;

	public float RankPercent;

	public ParticleSystem PlayheadSparkles;

	public bool onbackbeat;

	public bool onbeat;

	public bool onstarbeat;

	public bool offbeat;

	public bool offbackbeat;

	public bool offstarbeat;

	public bool offanybeat;

	public bool onanybeat;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void On_Intro(KoreographyEvent evt)
	{
	}

	private void On_Extra(KoreographyEvent evt)
	{
	}

	private void On_Butt(KoreographyEvent evt)
	{
	}

	private void SwitchCam()
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

	private void On_PLineStart(KoreographyEvent evt)
	{
	}

	private void On_PLineEnd(KoreographyEvent evt)
	{
	}

	private void On_Ball(KoreographyEvent evt)
	{
	}

	private void KillNotes()
	{
	}

	private void On_Warning(KoreographyEvent evt)
	{
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(_003CGiveRank_003Ed__316))]
	private IEnumerator GiveRank()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBonus_003Ed__317))]
	private IEnumerator Bonus()
	{
		return null;
	}

	public void SkipResults()
	{
	}

	public void HeadOut()
	{
	}

	private void On_EndSong(KoreographyEvent evt)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForTS_003Ed__321))]
	private IEnumerator WaitForTS()
	{
		return null;
	}

	private void On_Starbeat(KoreographyEvent evt)
	{
	}

	private void On_Beat(KoreographyEvent evt)
	{
	}

	private void On_Backbeat(KoreographyEvent evt)
	{
	}

	private void On_Offbeat(KoreographyEvent evt)
	{
	}

	private void On_Offbackbeat(KoreographyEvent evt)
	{
	}

	private void On_Offstarbeat(KoreographyEvent evt)
	{
	}

	public void OnBeatPoints()
	{
	}

	public void OnPinkPoints()
	{
	}
}
