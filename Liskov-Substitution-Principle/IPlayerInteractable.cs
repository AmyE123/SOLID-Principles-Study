using UnityEngine;

// Create an interface that all collision types can implement
public interface IPlayerInteractable
{
    void OnPlayerCollide(PlayerMovement player);
}
