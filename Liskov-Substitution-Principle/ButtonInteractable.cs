using UnityEngine;

// Create implementations
public class ButtonInteractable : MonoBehaviour, IPlayerInteractable
{
    public ButtonCommand buttonCommand;
    public SoundFX soundFX;
    public AudioClip buttonClickSound;

    public void OnPlayerCollide(PlayerMovement player)
    {
        buttonCommand.LowerBlockage();
        soundFX.PlaySound(buttonClickSound);
        Debug.Log("Player activated button!");
    }
}
