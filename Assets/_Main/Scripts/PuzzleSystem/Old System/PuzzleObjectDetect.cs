using System;
using UnityEngine;

namespace _Main.Scripts.PuzzleSystem
{
    public class PuzzleObjectDetect : MonoBehaviour
    {
        private RaycastHit _hit;


        private void Update()
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out _hit))
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * _hit.distance);

            }
        }
    }
}