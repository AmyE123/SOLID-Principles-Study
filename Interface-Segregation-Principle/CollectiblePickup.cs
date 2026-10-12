using UnityEngine;

public class CollectiblePickup : MonoBehaviour, IPlayerInteractable
{
    public int pointsValue = 10;
    public SoundFX soundFX;
    public AudioClip pickupSound;

    public void OnPlayerCollide(PlayerMovement player)
    {
        Debug.Log($"Collected {pointsValue} points!");
        soundFX.PlaySound(pickupSound);
        gameObject.SetActive(false);
    }
}
