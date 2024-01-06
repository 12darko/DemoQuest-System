using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace _Main.Scripts.PuzzleSystem
{
    public class PuzzlePoint : MonoBehaviour
    {
        [SerializeField] private int puzzleQue;
        [SerializeField] private bool isTrue;
        [SerializeField] private string requirePuzzleName;

        public int PuzzleQue
        {
            get => puzzleQue;
            set => puzzleQue = value;
        }

        public bool IsTrue
        {
            get => isTrue;
            set => isTrue = value;
        }

        public string RequirePuzzleName
        {
            get => requirePuzzleName;
            set => requirePuzzleName = value;
        }
    }
}
 