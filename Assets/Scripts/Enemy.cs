using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 15;

    [SerializeField] float enemyHp = 3;

    [SerializeField] float emdamage = 1;

    public float EnemyHp => enemyHp;

    AudioSource ad;

    private void Start()
    {
        ad = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;


    }

    

    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHP>().TakeDamage(emdamage);
            Destroy(gameObject);
        }
        if (other.CompareTag("Castle"))
        {
            other.GetComponent<CastleHP>().TakeDamage2(emdamage);
            Destroy(gameObject);
        }
        
    }

    public void TakeDamage(float damage)
    {
        enemyHp -= damage;

        if(enemyHp <= 0)
        {
            ad.Play();
            ScoreViewer.Instance.ScoreUP();
            //Destroy(gameObject);
            Invoke("DestroyGameObject",0.1f);
        }
    }

    private void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
