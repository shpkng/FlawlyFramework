// Author: wuchenyang(shpkng@gmail.com)

using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace FF.UI
{
    public class TabItem : UIBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler, ISelectHandler,
        IDeselectHandler, IInteractable
    {
        public int id;
        public bool _interactable;
        [SerializeField] private bool deselectOnNotInteractable;
        private bool selected;
        public IEffect onSelectEffect, onDeselectEffect, onBeInteractable, onNotInteractable;
        private UnityEvent<bool> onSelect;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.dragging)
                return;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
        }

        public void OnPointerUp(PointerEventData eventData)
        {
        }

        private void InternalSelect()
        {
            selected = true;
        }

        public void OnSelect(BaseEventData eventData)
        {
            if (!_interactable)
                return;
            InternalSelect();
        }

        private void InternalDeselect()
        {
            selected = false;
        }

        public void OnDeselect(BaseEventData eventData)
        {
            InternalDeselect();
        }

        public bool interactable => _interactable;

        public void OnInteractabilityChange(bool toBeInteractable)
        {
            if (selected && !toBeInteractable && deselectOnNotInteractable)
            {
                InternalDeselect();
            }
        }
    }
}