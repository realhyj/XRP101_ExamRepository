using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
    [SerializeField] private float _deactiveTime;
    private WaitForSeconds _wait;
    private Button _popupButton;

    [SerializeField] private GameObject _popup;

    

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _wait = new WaitForSeconds(_deactiveTime);
        _popupButton = GetComponent<Button>();
        SubscribeEvent();
    }

    private void SubscribeEvent()
    {
        _popupButton.onClick.AddListener(Activate);
    }

    private void Activate()
    {
        _popup.gameObject.SetActive(true);
        GameManager.Instance.Pause(); // �ȵǴ� ��
        StartCoroutine(DeactivateRoutine());
    }

    private void Deactivate()
    {
        Debug.Log("�ݱ�");
        _popup.gameObject.SetActive(false);
    }

    private IEnumerator DeactivateRoutine()
    {
        Debug.Log("���");
        yield return _wait; // �ȵǴ� ��
        Deactivate();
    }
}
