using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _enemyBullet;
    [SerializeField] private GameObject _playerBullet;
    public Vector3 targetDir;

    public IEnumerator FireBullet()
    {
        while (true)
        {
            GameObject bullet = Instantiate(_enemyBullet);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            yield return new WaitForSeconds(1.5f);
        }
    }

    public IEnumerator FirePlayerBullet()
    {
        while (true)
        {
            GameObject bullet = Instantiate(_playerBullet);
            bullet.transform.position = transform.position;
            bullet.transform.rotation = transform.rotation;
            yield return new WaitForSeconds(0.5f);
        }
    }

    public void LookAt()
    {
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
    }
}
