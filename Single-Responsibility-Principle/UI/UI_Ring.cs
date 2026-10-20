using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

// This file has been edited, and it now has the single responsibility of displaying the hold down charge ring at the cursor point. 
// Should rename to UIRing.cs to fit other naming conventions
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

    void OnEnable()
    {
        holdManager.ChargeStepped += OnChargeStepped;
        holdManager.ChargeReleased += OnChargeReleased;
    }

    void OnDisable()
    {
        holdManager.ChargeStepped -= OnChargeStepped;
        holdManager.ChargeReleased -= OnChargeReleased;
    }

    void Start()
    {
        fillRing.fillAmount = 0;
    }

    void Update()
    {
        circlePos.position = Input.mousePosition;
        numberText.SetText(holdManager.numberSpaces.ToString());
    }

    void OnChargeStepped(int step)
    {
        ChargeRing();
    }

    void OnChargeReleased(int spaces)
    {
        FadeOut_Fin();
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
        fillRing.DOFade(0.8f, 1);
        outerRing.DOFade(0.5f, 1);
        numberText.DOFade(1, 1);
        fillRing.fillAmount += FillMultiplier;
    }
}
