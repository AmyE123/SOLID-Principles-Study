using UnityEngine;

public class EnemyCollider : MonoBehaviour, IPlayerInteractable
{
    public ParticleSystem playerExplosion;
    public SoundFX soundFX;
    public AudioClip deathSound;

    public void OnPlayerCollide(GameObject player)
    {
        var killable = player.GetComponent<IKillable>();
        if (killable == null) return;

        soundFX.PlaySound(deathSound);
        Debug.Log("Player hit enemy!");
        killable.Kill(playerExplosion);
    }
}
