using System;
using UnityEngine;

namespace _Main.Scripts.EnemySystem
{
    public class ShootingEnemy : MonoBehaviour
    {
        [SerializeField] private Enemy enemy;
        [SerializeField] private float timeBetweenShots;
        [SerializeField] private float nextShotTime;
        [SerializeField] private GameObject bulletPrefab;


        private void Update()
        {
          BulletShot();
        }

        private void BulletShot()
        {
            if (Time.time > nextShotTime)
            {
                Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                nextShotTime = Time.time + timeBetweenShots;
            }
            
            if (Vector3.Distance(transform.position,enemy.target.position) < enemy.minDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position, enemy.target.position,
                    -enemy.enemySpeed * Time.deltaTime);
            }
        }
    }
}