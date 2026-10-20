using UnityEngine;
using DG.Tweening;

public class ObstacleRotator : MonoBehaviour, ILevelEventListener
{
    public float rotationDuration = 2f;

    public void OnLevelFlip(bool isUprightRotation)
    {
        float targetRotation = isUprightRotation ? 180f : 0f;
        transform.DORotate(new Vector3(0, 0, targetRotation), rotationDuration);
    }
}
