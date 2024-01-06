using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Main.Scripts.PuzzleSystem
{
    public class PuzzleBackPiecesList : MonoBehaviour
    {
        public void List()
        {
            var pManager = PuzzleManager.Instance;

            foreach (var pPoint in pManager.PuzzlePoint)
            {
                Debug.Log("test");
             //   pPoint.PuzzleQue = Random.Range(0, pManager.PuzzleHolders.Length);
            }
        }
    }
}