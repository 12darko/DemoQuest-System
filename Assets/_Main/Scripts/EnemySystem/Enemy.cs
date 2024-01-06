using UnityEngine;

namespace _Main.Scripts.EnemySystem
{
    [CreateAssetMenu(fileName = "Enemy", menuName = "EnemySystem/Enemy", order = 0)]
    public class Enemy : ScriptableObject
    {
        public EnemyType enemyType;
        public Transform target;
        public float enemySpeed;
        public float minDistance;
    }
}