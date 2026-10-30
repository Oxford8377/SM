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

public class MentorIcoRiv2 : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CGiveRank_003Ed__229 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MentorIcoRiv2 _003C_003E4__this;

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
		public _003CGiveRank_003Ed__229(int _003C_003E1__state)
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
	private sealed class _003CBonus_003Ed__230 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MentorIcoRiv2 _003C_003E4__this;

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
		public _003CBonus_003Ed__230(int _003C_003E1__state)
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
	private sealed class _003CWaitForTS_003Ed__234 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MentorIcoRiv2 _003C_003E4__this;

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
		public _003CWaitForTS_003Ed__234(int _003C_003E1__state)
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

	public bool SongLoaded;

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

	public bool HideNotes;

	public bool DoubleLineNext;

	public Animator Rep;

	public Animator Sup;

	public Animator Double;

	public Animator NextLine;

	public Animator NextLine2;

	public Animator NextLineWhole;

	public AudioSource ColorSwap;

	public AudioClip colorswap;

	public GameObject playerico;

	public GameObject Danny;

	public List<GameObject> Phantoms;

	public bool PLineStarted;

	public bool PmoveToTop;

	private bool PmoveOvershot;

	public ParticleSystem Trail;

	public int ExtraCount;

	public static int MentorFunkneeded;

	public AudioSource IntroAmb;

	public int IntroCount;

	public GameObject WaveSky;

	public GameObject NamiCursor;

	public GameObject NamiCursor2;

	public bool dontSpeak;

	public GameObject Line2P;

	public GameObject Line5P;

	public GameObject Line12P;

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

	public GameObject IntroScene;

	public GameObject Scene1;

	public GameObject Scene2;

	public GameObject Scene3;

	public GameObject Scene4;

	public GameObject Scene5;

	public GameObject Scene5Mel;

	public GameObject Scene6;

	public GameObject SceneSKG;

	public GameObject Scene7;

	public GameObject Scene8;

	public GameObject EndScene;

	public GameObject MelWindow;

	public GameObject OtherWindow;

	public GameObject DolphinJump;

	public TextMeshProUGUI caption;

	public Animator CurrentAnimator;

	public Animator PlayerL1;

	public Animator MentorL1;

	public Animator MentorL1b;

	public Animator MentorL2;

	public Animator MentorL3;

	public Animator MentorL4;

	public Animator MentorL5;

	public Animator MentorL6;

	public Animator MentorL7;

	public Animator MentorL8;

	public Animator Scene1Cam;

	public new Animator camera;

	public bool done;

	public float Speed;

	public AudioSource Song;

	private bool active;

	public static bool activeStatic;

	public static bool ActiveRecovery;

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

	public float Line;

	public AudioClip[] ClipList;

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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void On_Extra(KoreographyEvent evt)
	{
	}

	private void On_ReturnHome(KoreographyEvent evt)
	{
	}

	private void On_Intro(KoreographyEvent evt)
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

	private void On_PinkWarning(KoreographyEvent evt)
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

	[IteratorStateMachine(typeof(_003CGiveRank_003Ed__229))]
	private IEnumerator GiveRank()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CBonus_003Ed__230))]
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

	[IteratorStateMachine(typeof(_003CWaitForTS_003Ed__234))]
	private IEnumerator WaitForTS()
	{
		return null;
	}

	public void OnBeatPoints()
	{
	}

	public void OnPinkPoints()
	{
	}
}
