// Author: wuchenyang(shpkng@gmail.com)

namespace FF.UI
{
    public interface IInteractable
    {
        bool interactable { get; }
        void OnInteractabilityChange(bool toBeInteractable);
    }
}