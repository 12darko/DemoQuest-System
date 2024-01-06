using System;
using UnityEngine;

namespace _Main.Scripts.EnemySystem
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float bulletSpeed;
        [SerializeField] private Transform player;
        [SerializeField] private Vector3 target;

        private void Start()
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
            target = new Vector3(player.position.x, player.position.y, player.position.z);

        }

        private void Update()
        {
            BulletMove();
        }

        private void BulletMove()
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, bulletSpeed * Time.deltaTime);
            if (transform.position.x == target.x && transform.position.y == target.y)
            {
                DestroyBullet();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                DestroyBullet();
            }
        }

        private void DestroyBullet()
        {
            Destroy(gameObject);
        }
    }
}