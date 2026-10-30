using System.Collections.Generic;
using UnityEngine;

public class ES3AutoSave : MonoBehaviour, ISerializationCallbackReceiver
{
	public bool saveChildren;

	private bool isQuitting;

	public List<Component> componentsToSave;

	public void Awake()
	{
	}

	public void OnApplicationQuit()
	{
	}

	public void OnDestroy()
	{
	}

	public void OnBeforeSerialize()
	{
	}

	public void OnAfterDeserialize()
	{
	}
}
