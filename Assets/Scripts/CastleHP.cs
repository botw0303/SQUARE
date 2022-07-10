using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CastleHP : MonoBehaviour
{
    [SerializeField] float currentHP;
    [SerializeField] float maxHP;

    public float CurrentHP => currentHP;
    public float MaxHP => maxHP;

    public void TakeDamage2(float damage)
    {
        currentHP -= damage;

        if (currentHP <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
