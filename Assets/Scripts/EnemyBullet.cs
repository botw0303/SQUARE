using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float emdamage;

    AudioSource ads;

    private void Start()
    {
        ads = GetComponent<AudioSource>();
    }

    private void Update()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);
        if(transform.position.x > 36 || transform.position.x < -18)
        {
            Destroy(gameObject); 
        }
        if(transform.position.y > 19.3f + 0.5)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHP>().TakeDamage(emdamage);
            Destroy(gameObject);
        }
    }
}
