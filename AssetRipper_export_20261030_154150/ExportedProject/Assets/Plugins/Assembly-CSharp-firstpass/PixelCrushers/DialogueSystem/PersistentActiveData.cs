using UnityEngine;

namespace PixelCrushers.DialogueSystem
{
	[AddComponentMenu(null)]
	public class PersistentActiveData : MonoBehaviour
	{
		[Tooltip("The GameObject to set active or inactive based on the Condition below.")]
		public GameObject target;

		[Tooltip("If true, Target is activated; otherwise deactivated.")]
		public Condition condition;

		[Tooltip("When script starts, check condition & set target GameObject active/inactive. Otherwise it only checks when a game is loaded or entering from another scene.")]
		public bool checkOnStart;

		protected virtual void Start()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		public void OnApplyPersistentData()
		{
		}

		public virtual void Check()
		{
		}
	}
}
