using System;
using _Main.Scripts.CraftSystem;
using _Main.Scripts.CraftSystem.Old_System_Example;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;


namespace _Main.Scripts.QuestSystem
{
    public class QuestController : MonoBehaviour
    {
        [SerializeField] private MaterialType type;

        private UnityAction _coinAmountUpdate;


        private void ControlType(MaterialController controller)
        {
            foreach (var questHolder in QuestManager.Instance.Quests)
            {
                if (questHolder.mType == type)
                {
                    _coinAmountUpdate += () => { questHolder.properties.count += controller.MaterialAmount; };
                }
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Enemy"))
            {
                type = collision.collider.GetComponent<MaterialInObject>().Type;
                ControlType(collision.collider.GetComponent<MaterialController>());
                _coinAmountUpdate?.Invoke();
            }

            if (!collision.collider.CompareTag("Collectable")) return;
            type = collision.collider.GetComponent<MaterialInObject>().Type;
            ControlType(collision.collider.GetComponent<MaterialController>());
            _coinAmountUpdate?.Invoke();
            
            //PlayerPrefs.SetInt("Id");
        }
    }
}