using UnityEngine;

// This file has been created to have a single responsibility of making the movement on hold down charge work and move the player
public class PlayerMoveOnRelease : MonoBehaviour
{
    public HoldMouse holdMouse;
    public PlayerMovement[] players;

    void OnEnable()
    {
        holdMouse.ChargeReleased += MovePlayers;
    }

    void OnDisable()
    {
        holdMouse.ChargeReleased -= MovePlayers;
    }

    void MovePlayers(int spaces)
    {
        foreach (PlayerMovement p in players)
        {
            p.PlayerMove(spaces);
        }
    }
}
