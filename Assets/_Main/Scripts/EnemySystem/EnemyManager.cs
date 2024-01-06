using System;
using System.Collections;
using System.Collections.Generic;
using _Main.Scripts.EnemySystem;
using Unity.Mathematics;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
   [SerializeField] private Enemy enemy;
   [SerializeField] private Transform player;

   [SerializeField] private float timeShots;

   [SerializeField] private float startTimeShots;
   [SerializeField] private GameObject bulletPrefab;
   private void Start()
   {
      player = GameObject.FindGameObjectWithTag("Player").transform;
      timeShots = startTimeShots;
   }

   private void Update()
   {
    
   }
 

  
}
