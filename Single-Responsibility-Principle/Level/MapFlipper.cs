using UnityEngine;

// This file has been created, and it has a single responsibility to flip the level map whenever the player taps.
public class MapFlipper : MonoBehaviour
{
    public HoldMouse holdMouse;
    public LevelManager levelManager;
    public bool upright = true;

    void OnEnable()
    {
        holdMouse.Tapped += Flip;
    }

    void OnDisable()
    {
        holdMouse.Tapped -= Flip;
    }

    void Flip()
    {
        levelManager.FlipMap(upright);
        upright = !upright;
    }
}
