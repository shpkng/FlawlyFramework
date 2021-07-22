using UnityEditor;

namespace FF.UI
{
    [CustomEditor(typeof(RectTransformInspector), false)]
    [CanEditMultipleObjects]
    public class RectTransformInspector : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
        }
    }
}