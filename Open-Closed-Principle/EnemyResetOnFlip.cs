using UnityEngine;

public class EnemyResetOnFlip : MonoBehaviour, ILevelEventListener
{
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    public void OnLevelFlip(bool isUprightRotation)
    {
        transform.position = startPosition;
    }
}
