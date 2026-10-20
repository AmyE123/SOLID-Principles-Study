using UnityEngine;

// This file has been created, and it has a single responsibility to deal with the player grids when they charge their movement
public class PlayerGridPreview : MonoBehaviour
{
    public HoldMouse holdMouse;
    public PlayerMovement movement;
    public GameObject[] gridTiles;

    void Start()
    {
        ShowTiles(0);
    }

    void Update()
    {
        int charged = holdMouse.numberSpaces;
        bool inRange = charged >= 1 && charged <= gridTiles.Length;
        ShowTiles(movement.isActive && inRange ? charged : 0);
    }

    void ShowTiles(int count)
    {
        for (int i = 0; i < gridTiles.Length; i++)
        {
            gridTiles[i].SetActive(i < count);
        }
    }
}
