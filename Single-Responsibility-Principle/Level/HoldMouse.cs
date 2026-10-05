using System;
using UnityEngine;

// This file has been edited, to have a single responsibility. Beforehand it did a lot more, but now it only checks the mouse input for tap or hold, and it knows nothing about sound, ui, players or the map, other components would subscribe to its events.
public class HoldMouse : MonoBehaviour
{
    [Header("Data Values")]
    public int numberSpaces = 0;
    public float clickDelay = 0.25f;
    public float fullChargeDelay = 0.5f;

    const float ClickDelayReset = 0.25f;
    const int MaxSpaces = 5;

    bool isCharging = false;
    
    public event Action<int> ChargeStepped;
    
    public event Action<int> ChargeReleased;
    
    public event Action Tapped;

    void Update()
    {
        ButtonPress();

        if (numberSpaces >= MaxSpaces)
        {
            numberSpaces = 1;
        }
    }

    void ButtonPress()
    {
        if (Input.GetMouseButton(0))
        {
            clickDelay -= Time.deltaTime;
            if (clickDelay <= 0)
            {
                OnHoldDown();
            }
        }
        else if (isCharging)
        {
            Release();
        }
        else
        {
            numberSpaces = 0;
        }

        if (Input.GetMouseButtonUp(0))
        {
            clickDelay = ClickDelayReset;
            if (numberSpaces <= 0)
            {
                Tapped?.Invoke();
            }
        }
    }

    void OnHoldDown()
    {
        isCharging = true;
        numberSpaces += 1;
        clickDelay = ClickDelayReset;
        ChargeStepped?.Invoke(numberSpaces);
    }

    void Release()
    {
        isCharging = false;
        clickDelay = ClickDelayReset;
        ChargeReleased?.Invoke(numberSpaces);
    }
}
