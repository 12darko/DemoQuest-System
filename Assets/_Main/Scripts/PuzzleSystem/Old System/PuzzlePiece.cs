using UnityEngine;

namespace _Main.Scripts.PuzzleSystem
{
    [CreateAssetMenu(fileName = "Piece", menuName = "PuzzleSystem/Piece", order = 0)]
    public class PuzzlePiece : ScriptableObject
    {
        public int puzzlePieceQue;
        public string puzzlePieceName;
    }
}