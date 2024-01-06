using System;
using UnityEngine;

namespace _Main.Scripts.PuzzleSystem
{
    public class PuzzleMovement : MonoBehaviour
    {
     [SerializeField]  private GameObject selectedObject;
        private void Update()
        {
            Grab();
        }

        private void Grab()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("1");
                if (selectedObject == null)
                {
                    RaycastHit hit = RaycastHit();
                    if (hit.collider != null)
                    {
                        if (!hit.collider.CompareTag("PuzzleObject"))
                        {
                            return;
                        }

                        selectedObject = hit.collider.gameObject;
                        Cursor.visible = false;
                    }
                }
                else
                {
                    var position = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                        Camera.main.WorldToScreenPoint(selectedObject.transform.position).z);
                    var worldPos = Camera.main.ScreenToWorldPoint(position);
                    selectedObject.transform.position = new Vector3(worldPos.x, 0f, worldPos.z);

                    selectedObject = null;
                    Cursor.visible = true;
                }
            }

            if (selectedObject != null)
            {
                var position = new Vector3(Input.mousePosition.x, Input.mousePosition.y,
                    Camera.main.WorldToScreenPoint(selectedObject.transform.position).z);
                var worldPos = Camera.main.ScreenToWorldPoint(position);
                selectedObject.transform.position = new Vector3(worldPos.x, 0f, worldPos.z);
            }
        }

        private RaycastHit RaycastHit()
        {
            var screenMousePosFar = new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.farClipPlane
            );

            var screenMousePosNear = new Vector3(
                Input.mousePosition.x,
                Input.mousePosition.y,
                Camera.main.nearClipPlane
            );

            var worldMousePosFar = Camera.main.ScreenToWorldPoint(screenMousePosFar);
            var worldMousePosNear = Camera.main.ScreenToWorldPoint(screenMousePosNear);
            RaycastHit hit;
            Physics.Raycast(worldMousePosNear, worldMousePosFar - worldMousePosNear, out hit);
            return hit;

        }
    }
}