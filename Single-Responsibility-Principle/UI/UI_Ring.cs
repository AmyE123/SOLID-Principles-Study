using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class UI_Ring : MonoBehaviour
{
    [Header("References")]
    public HoldMouse holdManager;

    [Header("Data Values")]
    [Space(20)]
    float FillMultiplier = 0.25f;
    

    [Header("UI References")]
    [Space(20)]
    public Transform circlePos;
    public Image fillRing;
    public Image outerRing;
    public TextMeshProUGUI numberText;

    void Start()
    {
        fillRing.fillAmount = 0;
    }

    void Update()
    {
        var mousePos = Input.mousePosition;
        circlePos.position = new Vector3(mousePos.x, mousePos.y, mousePos.z);
        numberText.SetText(holdManager.numberSpaces.ToString());
        
    }

    public void FadeOut_Fin()
    {
        fillRing.fillAmount = 0;
        fillRing.DOFade(0, 1);
        outerRing.DOFade(0.25f, 1);
        numberText.DOFade(0, 1);
    }

    public void ChargeRing()
    {
        Debug.Log(holdManager.numberSpaces/4.0f);
        fillRing.DOFade(0.8f, 1);
        outerRing.DOFade(0.5f, 1);
        numberText.DOFade(1, 1);
        fillRing.fillAmount += FillMultiplier;
    }

}
