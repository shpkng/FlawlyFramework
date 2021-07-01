// Author: wuchenyang(shpkng@gmail.com)

public interface IInteractable
{
    bool interactable { get; }
    void OnInteractabilityChange(bool toBeInteractable);
}