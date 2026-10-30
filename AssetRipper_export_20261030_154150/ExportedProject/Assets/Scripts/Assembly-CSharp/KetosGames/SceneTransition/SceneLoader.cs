using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KetosGames.SceneTransition
{
	public class SceneLoader : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CInnerLoad_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SceneLoader _003C_003E4__this;

			public Scene scene;

			private float _003CstartTime_003E5__2;

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
			public _003CInnerLoad_003Ed__36(int _003C_003E1__state)
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

		private static SceneLoader SceneLoaderInstance;

		public GameObject LoadingScreen;

		public Image FadeImage;

		public Material FadeMaterial;

		[Tooltip("Use with VR.")]
		public bool VRMode;

		[Tooltip("When checked, use the Loading scene as the Loading screen (instead of the Loading UI).")]
		public bool UseSceneForLoadingScreen;

		[Tooltip("The name of the Loading scene to load.")]
		public string LoadingSceneName;

		[Tooltip("When checked, fade in the loading screen.")]
		public bool FadeInLoadingScreen;

		[Tooltip("When checked, fade out the loading screen.")]
		public bool FadeOutLoadingScreen;

		[Tooltip("The number of seconds to animate the fade.")]
		public float FadeSeconds;

		[Tooltip("The number of seconds to show the loading screen after fade in. Set it to 0 to go to the new scene as soon as it's ready.")]
		public float MinimumLoadingScreenSeconds;

		[Tooltip("The color to use in the fade animation.")]
		public Color FadeColor;

		[Tooltip("Whether to ignore timeScale. This is useful if you pause the sceen by setting the timescale to 0.")]
		public bool IgnoreTimeScale;

		[HideInInspector]
		public float Progress;

		private AsyncOperation SceneLoadingOperation;

		private bool FadingIn;

		private bool FadingOut;

		private float FadeTime;

		private Color FadeClearColor;

		private bool Loading;

		private bool VRInitialized;

		public static SceneLoader Instance => null;

		private float deltaTime => 0f;

		private float time => 0f;

		public static void LoadScene(string name)
		{
		}

		public static void LoadScene(int buildIndex)
		{
		}

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void Update()
		{
		}

		public void BeginFadeOut()
		{
		}

		public void BeginFadeIn()
		{
		}

		private void EndFadeIn()
		{
		}

		private void EndFadeOut()
		{
		}

		private void UpdateFadeIn()
		{
		}

		private void UpdateFadeOut()
		{
		}

		public void Load(string name)
		{
		}

		public void Load(int buildIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CInnerLoad_003Ed__36))]
		private IEnumerator InnerLoad(Scene scene)
		{
			return null;
		}

		private void UpdateCamera()
		{
		}

		private void SetFadersEnabled(bool value)
		{
		}

		private void setFadeColor(Color value)
		{
		}

		private void OnDestroy()
		{
		}
	}
}
