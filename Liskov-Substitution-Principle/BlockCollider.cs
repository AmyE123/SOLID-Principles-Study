using UnityEngine;
using DG.Tweening;

// Create implementations
public class BlockCollider : MonoBehaviour, IPlayerInteractable
{
    public Transform blockArea;

    public void OnPlayerCollide(PlayerMovement player)
    {
        player.transform.DOLocalMove(blockArea.position, player.speed);
        player.playerPos = blockArea.position;
        Debug.Log("Player blocked!");
    }
}
