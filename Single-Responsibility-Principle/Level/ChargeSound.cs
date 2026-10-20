using UnityEngine;

// This file has been created, and it has a single responsibility to play a sound for each charge step.
public class ChargeSound : MonoBehaviour
{
    public HoldMouse holdMouse;
    public SoundFX soundFX;
    public AudioClip[] gridSounds;

    void OnEnable()
    {
        holdMouse.ChargeStepped += PlayStepSound;
    }

    void OnDisable()
    {
        holdMouse.ChargeStepped -= PlayStepSound;
    }

    void PlayStepSound(int step)
    {
        soundFX.PlaySound(gridSounds[step - 1]);
    }
}
