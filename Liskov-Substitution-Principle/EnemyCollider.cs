using UnityEngine;
using DG.Tweening;

// Create implementations
public class EnemyCollider : MonoBehaviour, IPlayerInteractable
{
    public ParticleSystem playerExplosion;
    public SoundFX soundFX;
    public AudioClip deathSound;

    public void OnPlayerCollide(PlayerMovement player)
    {
        player.isHit = true;
        DOTween.Kill(player.transform);
        soundFX.PlaySound(deathSound);
        Debug.Log("Player hit enemy!");

        var deathPosition = Instantiate(playerExplosion, player.player);
        deathPosition.transform.SetParent(null);

        player.speed = 0;
        player.playerTransform();
    }
}
