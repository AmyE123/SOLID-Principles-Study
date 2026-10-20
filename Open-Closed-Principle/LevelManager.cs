using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

// This file has been edited,
public class LevelManager : MonoBehaviour
{
    public Transform level;
    public Vector3 rotateMap = new Vector3(0, 0, 180);

    [Header("Audio")]
    public SoundFX soundFX;
    public AudioClip flipMapFX;

    private List<ILevelEventListener> levelEventListeners = new();

    void Start()
    {
        levelEventListeners.AddRange(GetComponentsInChildren<ILevelEventListener>());
    }

    public void FlipMap(bool upright)
    {
        soundFX.PlaySound(flipMapFX);

        var targetRotation = upright ? new Vector3(0, 0, 180) : new Vector3(0, 0, 0);
        level.DORotate(targetRotation, 2);

        NotifyListeners(upright);
    }

    private void NotifyListeners(bool isUprightRotation)
    {
        foreach (var listener in levelEventListeners)
        {
            listener.OnLevelFlip(isUprightRotation);
        }
    }
}
