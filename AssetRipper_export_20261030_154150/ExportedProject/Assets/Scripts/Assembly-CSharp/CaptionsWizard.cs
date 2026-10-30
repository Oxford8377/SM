using SonicBloom.Koreo;
using TMPro;
using UnityEngine;

public class CaptionsWizard : MonoBehaviour
{
	public TextMeshProUGUI captions;

	[EventID]
	public string Caption;

	private void Start()
	{
	}

	private void On_Caption(KoreographyEvent evt)
	{
	}

	private void Update()
	{
	}
}
