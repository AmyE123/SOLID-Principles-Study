using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LevelManager : MonoBehaviour
{
    public Transform level;
    public Vector3 rotateMap = new Vector3(0, 0, 180);
    public PlayerManager playerManager;

    [Header("Audio")]
    public SoundFX soundFX;
    public AudioClip flipMapFX;

    public void FlipMap(bool upright)
    {
        soundFX.PlaySound(flipMapFX);

        if(upright)
        {
            level.DORotate(new Vector3(0, 0, 180), 2);
            playerManager.players[0].isActive = false;
            playerManager.players[1].isActive = true;

        }
        else if (!upright)
        {
            level.DORotate(new Vector3(0, 0, 0), 2);
            playerManager.players[0].isActive = true;
            playerManager.players[1].isActive = false;
        }
    }
}
