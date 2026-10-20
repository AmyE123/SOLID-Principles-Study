using UnityEngine;

public class BlockCollider : MonoBehaviour, IPlayerInteractable
{
    public Transform blockArea;

    public void OnPlayerCollide(GameObject player)
    {
        var blockable = player.GetComponent<IBlockable>();
        if (blockable == null) return;

        blockable.BlockAt(blockArea.position);
        Debug.Log("Player blocked!");
    }
}
