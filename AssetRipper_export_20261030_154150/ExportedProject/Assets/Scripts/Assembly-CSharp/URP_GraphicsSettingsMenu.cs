using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class URP_GraphicsSettingsMenu : MonoBehaviour
{
	public enum saveFormat
	{
		playerprefs = 0,
		iniFile = 1
	}

	private class MenuVariables
	{
		public int Qualitylevel;

		public int ResolutionX;

		public int ResolutionY;

		public bool WindowedMode;

		public bool VSync;

		public int TextureQuality;

		public int AnisotropicMode;

		public int AnisotropicLevel;

		public string Warning;
	}

	[CompilerGenerated]
	private sealed class _003CSetTextureQualityCoroutine_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public URP_GraphicsSettingsMenu _003C_003E4__this;

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
		public _003CSetTextureQualityCoroutine_003Ed__37(int _003C_003E1__state)
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

	public saveFormat saveAs;

	[Tooltip("Check for IOS and Windows Store Apps.")]
	public bool usePersistentDatapath;

	[Header("THESE NEED TO BE DRAGGED IN")]
	public RenderPipelineAsset[] renderPipelines;

	[Space]
	public Slider qualityLevelSlider;

	public Slider textureQualitySlider;

	public Slider anisotropicModeSlider;

	public Slider anisotropicLevelSlider;

	public Text qualityText;

	public Text textureText;

	public Text anisotropicModeText;

	public Text anisotropicLevelText;

	public GameObject resolutionsPanel;

	public GameObject resButtonPrefab;

	public GameObject menuTransform;

	public Text currentResolutionText;

	public Toggle windowedModeToggle;

	public Toggle vSyncToggle;

	private GameObject resolutionsPanelParent;

	private Resolution[] resolutions;

	private bool setMenu;

	private bool openMenu;

	private bool fullScreenMode;

	private bool toggleVSync;

	private float setTextQualDelay;

	private int wantedResX;

	private int wantedResY;

	private string saveFileDataPath;

	private Coroutine setTextQualityCoR;

	private MenuVariables saveVars;

	private MenuVariables DefaultSettings;

	private void Start()
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

	public void SetTextureQuality()
	{
	}

	[IteratorStateMachine(typeof(_003CSetTextureQualityCoroutine_003Ed__37))]
	private IEnumerator SetTextureQualityCoroutine()
	{
		return null;
	}

	public void SetAnisotropicFiltering()
	{
	}

	public void SetAnisotropicFilteringLevel()
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
