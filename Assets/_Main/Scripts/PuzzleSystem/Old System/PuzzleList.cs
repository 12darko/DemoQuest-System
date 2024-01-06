using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace _Main.Scripts.PuzzleSystem
{
    public class PuzzleList : MonoBehaviour
    {
        private void Start()
        {
            PuzzleQueList();;
        }

        private void PuzzleQueList()
        {
            var pManager = PuzzleManager.Instance;
            foreach (var pHolder in pManager.PuzzleHolders)
            {
                pHolder.puzzlePieceQue = pHolder.piece.puzzlePieceQue;
                pHolder.puzzlePieceObject.transform.GetComponent<PuzzleObjects>().ObjectQue =
                    pHolder.piece.puzzlePieceQue;
            }
        }
    }
}