using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateSpeedButton : MonoBehaviour
{
    [SerializeField] private Button _plusButton;
    [SerializeField] private Button _minusButton;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        SubscribeEvent();
    }

    private void SubscribeEvent()
    {
        _plusButton.onClick.AddListener(PlusScore);
        _minusButton.onClick.AddListener(MinusScore);
    }

    private void PlusScore() 
    {
        Debug.Log("╩С╫б");
        GameManager.Instance.Score += 0.05f;
    }
    private void MinusScore()
    {
        Debug.Log("го╤Т");
        GameManager.Instance.Score -= 0.05f;
    }
}
