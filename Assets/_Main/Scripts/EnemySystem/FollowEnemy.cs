using System;
using UnityEngine;

namespace _Main.Scripts.EnemySystem
{
    public class FollowEnemy : MonoBehaviour
    {
        [SerializeField] private Enemy enemy;
        

        private void Start()
        {
            enemy.target = GameObject.FindGameObjectWithTag("Player").transform;
        }

        private void Update()
        {
            Follow();
        }

        private void Follow()
        {
            if (Vector3.Distance(transform.position,  enemy.target .position) > enemy.minDistance)
            {
                transform.position = Vector3.MoveTowards(transform.position,  enemy.target .position,
                    enemy.enemySpeed * Time.deltaTime);
            }
        }
    }
}