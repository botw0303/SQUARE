using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoGun : LookAtEnemy
{
    [SerializeField] private LayerMask _enemyLayer;
    Vector3 _enemyPos;

    private List<Transform> _enemyList = new List<Transform>();
    void Start()
    {
        StartCoroutine(FirePlayerBullet());
    }   

    void Update()
    {
        _enemyList.Add(GameObject.FindGameObjectWithTag("Enemy").transform);
        _enemyPos = _enemyList[0].transform.position;
        targetDir = _enemyPos - transform.position;

        if(_enemyList[0] != null)
        {
            _enemyList.RemoveAt(0);
        }
        LookAt();
    }
}
