using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class HoldMouse : MonoBehaviour
{
    [Header("References")]
    public UI_Ring ring_UI;
    public PlayerMovement[] players;
    public LevelManager levelManager;
    public SoundFX soundFX;
    public AudioClip[] gridSounds;
    
    
    [Header("Data Values")]
    [Space(20)]
    public int numberSpaces = 0;
    public float clickDelay = 0.25f;
    bool isCharging = false;
    public bool upright = true;
    public float fullChargeDelay = 0.5f;


    void start()
    {

    }

    void Update()
    {
        ButtonPress();
        
        if(numberSpaces >= 5)
        {
            numberSpaces = 1;

        }
    }

    void ButtonPress()
    {
        if(Input.GetMouseButton(0))
        {
            clickDelay -= Time.deltaTime; 
            if(clickDelay <= 0)
            {
                OnHoldDown();
            }

        }
        else if(isCharging)
        {
            MoveSpaces();
        }
        else
        {
            numberSpaces = 0;  
        }

        if(Input.GetMouseButtonDown(0))
        {

        }
        if(Input.GetMouseButtonUp(0))
        {
            clickDelay = 0.25f;
            if(numberSpaces <= 0)
            {
                levelManager.FlipMap(upright);
                upright = !upright;
            }
        }
    }

    void MoveSpaces()
    {
        ring_UI.FadeOut_Fin();
        isCharging = false;
        clickDelay = 0.25f;
        //player.PlayerMove(numberSpaces);
        foreach(PlayerMovement p in players)
        {
            p.PlayerMove(numberSpaces);
        }
    }

    void OnHoldDown()
    {
        ring_UI.ChargeRing();
        isCharging = true;
        numberSpaces+= 1;
        clickDelay = 0.25f;
        soundFX.PlaySound(gridSounds[numberSpaces - 1]);
    }

    void OnClick()
    {
        if(Input.GetMouseButtonDown(0))
        {

        }
        if(Input.GetMouseButtonUp(0))
        {
            clickDelay = 0.25f;
        }
    }

}
