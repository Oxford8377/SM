using Cinemachine;
using UnityEngine;

public class CinemachineSwitcher : MonoBehaviour
{
	public CinemachineVirtualCamera vcam;

	public CinemachineVirtualCamera prev_vcam;

	public CinemachineVirtualCamera prev_vcam2;

	public bool HasAlphaWall;

	public Animator AlphaWall;

	public string AWInOrOut;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void OnTriggerEnter(Collider coll)
	{
	}

	public void OnTriggerExit(Collider coll)
	{
	}
}
