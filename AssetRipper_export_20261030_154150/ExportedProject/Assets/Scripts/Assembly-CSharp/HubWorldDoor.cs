using UnityEngine;
using UnityEngine.UI;

public class HubWorldDoor : MonoBehaviour
{
	public GameObject Subject;

	public Animator SubjectAnim;

	public Vector3 NextLocation;

	public Vector3 Rotation;

	public Image Fade;

	public bool FadeIn;

	public bool Done;

	public Color FadeColor;

	public float FadeSpeed;

	public string Direction;

	private int direction;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void TakeTo()
	{
	}
}
