using Rewired;
using UnityEngine;

public class Item : MonoBehaviour
{
	public GameObject notifBox;

	public GameObject Selector;

	public bool nearby;

	public bool notifup;

	public Animator playerAn;

	public GameObject self;

	public GameObject inventoryGO;

	public AudioSource music;

	public AudioSource ItemSound;

	public SpriteRenderer rend;

	public CircleCollider2D collo;

	public string item;

	public int playerId;

	private Player player;

	private CharacterController cc;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void NotifUp()
	{
	}

	public void GiveItem()
	{
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
	}

	public void OnTriggerExit2D(Collider2D coll)
	{
	}
}
