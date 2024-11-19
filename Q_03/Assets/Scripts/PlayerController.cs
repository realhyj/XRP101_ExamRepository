using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 100)]
    public int Hp { get; private set; }

    [SerializeField] private AudioSource _audio;

    private void Awake()
    {
        Init();
    }
    
    private void Init()
    {
        _audio = GetComponent<AudioSource>();
    }
    
    public void TakeHit(int damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {

            Die();
        }
    }

    public void Die()
    {
        if (_audio == null)
        {
            Debug.LogError("AudioSource component is missing!");
            return;
        }

        if (_audio.clip == null)
        {
            Debug.LogError("AudioClip is missing in AudioSource!");
            return;
        }
        _audio.Play();
        gameObject.SetActive(false);
    }
}
