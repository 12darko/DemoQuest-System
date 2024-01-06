using DG.Tweening;
using UnityEngine;

namespace _Main.Scripts.PuzzleSystem
{
    public class PuzzleObjectScale : MonoBehaviour
    {
        public void PuzzleSize(GameObject hit , float scaleSizeX, float scaleSizeY)
        {
            hit.transform.DOScaleX(scaleSizeX, 1f).SetEase(Ease.Linear);
            hit.transform.DOScaleY(scaleSizeY, 1f).SetEase(Ease.Linear);
        }
    }
}