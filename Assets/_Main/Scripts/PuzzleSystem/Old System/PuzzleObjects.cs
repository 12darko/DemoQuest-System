using System;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace _Main.Scripts.PuzzleSystem
{
    public class PuzzleObjects : MonoBehaviour
    {
        [SerializeField] private PuzzlePoint point;
        [SerializeField] private PuzzleObjectScale puzzleObjectScale;
        [SerializeField] private Vector3 offset;
        [SerializeField] private int objectQue;
      
        private bool _size;
        

        #region Props

        public PuzzlePoint Point
        {
            get => point;
            set => point = value;
        }

        public int ObjectQue
        {
            get => objectQue;
            set => objectQue = value;
        }

     

        #endregion

        private void OnMouseDown()
        {
            offset = transform.position - MouseWorldPosition();
            transform.GetComponent<Collider>().enabled = false;
        }

        private void Update()
        {
            //  transform.position = MouseWorldPosition() + offset;
          
        }

        private void OnMouseDrag()
        {
            MovementObject();
        }

        private void OnMouseUp()
        {
            var rayOrigin = Camera.main.transform.position;
            var rayDirection = MouseWorldPosition() - Camera.main.transform.position;
            RaycastHit hitInfo;
            if (Physics.Raycast(rayOrigin, rayDirection, out hitInfo))
            {
                if (hitInfo.transform.GetComponent<PuzzlePoint>())
                {
                    point = hitInfo.transform.GetComponent<PuzzlePoint>();
                    puzzleObjectScale.PuzzleSize(gameObject, 2.5f, 3f);
                    transform.position = point.transform.position;
                }
            }
            transform.GetComponent<Collider>().enabled = true;
        }

        private Vector3 MouseWorldPosition()
        {
            var mouseScreenPos = Input.mousePosition;
            mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;

            return Camera.main.ScreenToWorldPoint(mouseScreenPos);
        }

        private void MovementObject()
        {
            if (!Input.GetMouseButton(0)) return;
            if (Mathf.Abs(offset.x) > Mathf.Abs(offset.y))
            {
                offset.y = 0;
                transform.position = new Vector3(MouseWorldPosition().x + offset.x * Time.deltaTime,
                    transform.position.y, transform.position.z);
            }
            else
            {
                offset.x = 0;
                transform.position = new Vector3(transform.position.x,
                    MouseWorldPosition().y + offset.y * Time.deltaTime, transform.position.z);
            }
        }
    }
}