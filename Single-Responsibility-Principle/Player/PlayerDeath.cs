using UnityEngine;

// This file has been created, and it has a single responsibility to handle the player's death with the fx and respawn.
public class PlayerDeath : MonoBehaviour
{
    public PlayerMovement movement;
    public Transform player;
    public ParticleSystem playerExplosion;
    public Vector3 startPos;
    public Vector3 deathPos;

    public SoundFX soundFX;
    public AudioClip deathSound;

    public void Die()
    {
        soundFX.PlaySound(deathSound);
        deathPos = movement.playerPos;

        var explosion = Instantiate(playerExplosion, player);
        explosion.transform.SetParent(null);

        movement.ResetTo(startPos);
    }
}
