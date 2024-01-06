using System;
using UnityEngine;

namespace _Main.Scripts.PuzzleSystem
{
    public class PuzzleDetection : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.gameObject.GetComponent<PuzzlePoint>())
            {
                if (transform.GetComponent<PuzzleObjects>().ObjectQue == collision.collider.gameObject.GetComponent<PuzzlePoint>().PuzzleQue)
                {
                    collision.collider.gameObject.GetComponent<PuzzlePoint>().IsTrue = true;
                    if (collision.collider.gameObject.GetComponent<PuzzlePoint>().IsTrue)
                    {
                        PuzzleManager.Instance.TrueControl += 1;
                    }
                    Debug.Log("Doğru");
                }
                else
                {
                    PuzzleManager.Instance.TrueControl -= 1;
                    if (PuzzleManager.Instance.TrueControl < 0 )
                    {
                        PuzzleManager.Instance.TrueControl = 0;  
                    }
                    Debug.Log("yanlış");
                }
            }
        }

        private void OnCollisionExit(Collision other)
        {
            other.collider.gameObject.GetComponent<PuzzlePoint>().IsTrue = false;
        }
    }
}