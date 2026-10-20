using UnityEngine;

// Implementers receive only the player's GameObject and ask it for the
// narrow capabilities (IBlockable, IKillable, ...) they actually need.
public interface IPlayerInteractable
{
    void OnPlayerCollide(GameObject player);
}
