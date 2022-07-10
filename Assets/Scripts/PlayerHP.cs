using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    [SerializeField] float currentHP;
    [SerializeField] float maxHP;

    public float CurrentHP => currentHP;
    public float MaxHP => maxHP;

    AudioSource ads;


    void Start()
    {
        ads = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        currentHP -= damage;
        ads.Play();

        if(currentHP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    
}
