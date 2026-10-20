using UnityEngine;

// This file has been created, and it has a single responsibility to deal with the collissions of the player.
public class PlayerCollisionHandler : MonoBehaviour
{
    public PlayerMovement movement;
    public PlayerDeath death;
    public ButtonCommand button;
    public Transform blockArea1;

    public SoundFX soundFX;
    public AudioClip buttonClick;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
            death.Die();
        }
        else if (other.CompareTag("button"))
        {
            button.LowerBlockage();
            soundFX.PlaySound(buttonClick);
        }
        else if (other.CompareTag("block"))
        {
            movement.StopAt(blockArea1.position);
        }
    }
}
