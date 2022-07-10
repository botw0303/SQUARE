using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunEnemy : LookAtEnemy
{
    [SerializeField] private Transform _playerTrm = null;


    private void Start()
    {
        StartCoroutine(FireBullet());
    }

    private void Update()
    {
        targetDir = _playerTrm.position - transform.position;

        LookAt();
    }

    
}
