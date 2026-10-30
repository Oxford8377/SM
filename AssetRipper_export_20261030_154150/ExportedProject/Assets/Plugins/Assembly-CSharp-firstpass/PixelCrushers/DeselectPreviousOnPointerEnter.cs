using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace PixelCrushers
{
	[AddComponentMenu(null)]
	[RequireComponent(typeof(Selectable))]
	public class DeselectPreviousOnPointerEnter : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IDeselectHandler
	{
		public void OnPointerEnter(PointerEventData eventData)
		{
		}

		public void OnDeselect(BaseEventData eventData)
		{
		}
	}
}
