using UnityEngine;
using DG.Tweening;

// This file has been edited, and it now has a single responsibility of moving the player along the grid, moving the input, grid stuff, death, collisions and sound to other files.
public class PlayerMovement : MonoBehaviour
{
    public Vector3 playerPos;
    public float speed = 0.5f;
    public bool isActive = true;
    public Vector3 moveDirection = Vector3.right;

    const float DefaultSpeed = 0.5f;

    public void PlayerMove(int numberOfSpaces)
    {
        if (!isActive) return;

        playerPos += moveDirection * numberOfSpaces;
        transform.DOLocalMove(playerPos, speed);
    }

    public void StopAt(Vector3 position)
    {
        transform.DOLocalMove(position, speed);
        playerPos = position;
    }

    public void ResetTo(Vector3 position)
    {
        DOTween.Kill(transform);
        transform.localPosition = position;
        playerPos = position;
        speed = DefaultSpeed;
    }
}
