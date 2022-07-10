using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Enemy enemy;
    [SerializeField] float damage = 1f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Vector3.up * 30/*¿©±â Åº¼Ó ¹Ù²Ù¸é µÊ*/ * Time.deltaTime); 
        if(transform.position.y > 19.3f + 0.5)
        {
            Destroy(gameObject);
        }
    }

    

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //ScoreViewer.Instance.ScoreUP();
            other.GetComponent<Enemy>().TakeDamage(damage);
            Destroy(gameObject);
        
        }
    }
}
