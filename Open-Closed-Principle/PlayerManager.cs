using UnityEngine;

public class PlayerManager : MonoBehaviour, ILevelEventListener
{
    public PlayerMovement[] players;

    void Start()
    {
        players[0].isActive = true;
        players[1].isActive = false;

        players[0].playerPos = new Vector3(-15, 1, 0.5f);
        players[1].playerPos = new Vector3(-15, -1, 0.5f);
    }

    public void OnLevelFlip(bool isUprightRotation)
    {
        players[0].isActive = !isUprightRotation;
        players[1].isActive = isUprightRotation;
    }
}
