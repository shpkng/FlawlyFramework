// Author: wuchenyang(shpkng@gmail.com)

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace FF.UI
{
    [ExecuteAlways]
    public class SoftMask : UIBehaviour, ICanvasElement
    {
        private RectTransform m_RectTransform;

        public RectTransform rectTransform => m_RectTransform ??= transform as RectTransform;
        public float xMax, xMin, yMax, yMin;

        protected override void OnEnable()
        {
            CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(this);
        }

        public void Rebuild(CanvasUpdate executing)
        {
            Canvas up;
        }

        public void LayoutComplete()
        {
            
        }

        public void GraphicUpdateComplete()
        {
            
        }
    }
}